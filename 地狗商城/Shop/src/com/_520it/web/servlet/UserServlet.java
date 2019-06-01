package com._520it.web.servlet;

import java.io.IOException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Map;

import javax.servlet.ServletException;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import org.apache.commons.beanutils.BeanUtils;
import org.apache.commons.beanutils.ConvertUtils;
import org.apache.commons.beanutils.Converter;

import com._520it.domain.User;
import com._520it.service.UserService;
import com._520it.util.CommonsUtil;
import com._520it.util.MailUtils;

public class UserServlet extends BaseServlet {

//	public void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
//		request.setCharacterEncoding("UTF-8");
//		String methodName = request.getParameter("methodName");
//		if (methodName.equals("active")) {
//			active(request,response);
//		}else if(methodName.equals("checkUsername")) {
//			checkUsername(request,response);
//		}else if(methodName.equals("login")) {
//			login(request,response);
//		}else if(methodName.equals("register")) {
//			register(request,response);
//		}
//	}
//
//	public void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
//		doGet(request, response);
//	}

	/**
	 * �����˻�
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void active(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// ��ü�����
		String activeCode = request.getParameter("activeCode");
		// ���ݲ�����service��
		UserService service = new UserService();
		service.active(activeCode);
		// �ض��򵽵�¼����
		response.sendRedirect(request.getContextPath() + "/login.jsp");
	}

	/**
	 * ע��ǰ����û����Ƿ��Ѵ���
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void checkUsername(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		// ��ȡ����
		String username = request.getParameter("username");
		UserService service = new UserService();
		boolean isExist = service.checkUser(username);
		String json = "{\"isExist\":" + isExist + "}";
		response.getWriter().write(json);
	}

	
	/**
	 * ��¼����
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void login(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		// request.removeAttribute("loginInfo");
		// ������֤���Ƿ���ȷ
		String checkCodeInfo="";
		HttpSession session = request.getSession();
		Object checkcode_session = session.getAttribute("checkcode_session");
		String checkCode = request.getParameter("checkCode");
		if (!checkCode.equals(checkcode_session)) {
			checkCodeInfo = "��֤������";
			request.setAttribute("checkCodeInfo", checkCodeInfo);
			request.getRequestDispatcher("/login.jsp").forward(request, response);
			return;
		}

		// ��ȡ����
		String autoLogin = request.getParameter("autoLogin");
		//System.out.println(autoLogin);
		String username = request.getParameter("username");
		String password = request.getParameter("password");
		// �����������󴫵�service��
		UserService service = new UserService();
		User user = service.login(username, password);
		if (user != null) {
			// ��¼�ɹ�--�ض���������
			session.setAttribute("user", user);
			//���ѡ���Զ���¼,��user����cookie������
			if (autoLogin!=null) {
				//����cookie
				Cookie cookie_username =new Cookie("username", username);
				Cookie cookie_password =new Cookie("password", password);
				//����cookie��Я��·��
				cookie_username.setPath(request.getContextPath());
				cookie_password.setPath(request.getContextPath());
				//����cookie�ĳ־û�ʱ��
				cookie_username.setMaxAge(60*60*24*3);
				cookie_password.setMaxAge(60*60*24*3);
				//����cookie
				response.addCookie(cookie_username);
				response.addCookie(cookie_password);
			}
			//System.out.println(user);
			response.sendRedirect(request.getContextPath());
		} else {
			// ��¼ʧ��--����ת������¼����
			String loginInfo = "�˺����������˻�δ����";
			request.setAttribute("loginInfo", loginInfo);
			request.getRequestDispatcher("login.jsp").forward(request, response);
		}
	}

	
	/**
	 * �û�ע��
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void register(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
			
		try {
			// �ж���֤���Ƿ���ȷ
			String checkCode = request.getParameter("checkCode");
			System.out.println(checkCode);
			HttpSession session = request.getSession();
			String checkcode_session = (String) session.getAttribute("checkcode_session");
			if (!checkCode.equals(checkcode_session)) {
				session.removeAttribute("checkcode_session");
				request.setAttribute("registerInfo", "��֤�����");
				request.getRequestDispatcher("/register.jsp").forward(request, response);
				return;
			}
			// ��ȡ����װ����
			Map<String, String[]> map = request.getParameterMap();
			User user = new User();
			// �Լ�ָ��һ������ת��������Stringת����Date��
			ConvertUtils.register(new Converter() {
				public Object convert(Class arg0, Object arg1) {
					// ��Stringת����date
					SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd");
					Date parse = null;
					try {
						parse = format.parse(arg1.toString());
					} catch (ParseException e) {
						e.printStackTrace();
					}
					return parse;
				}
			}, Date.class);
			BeanUtils.populate(user, map);
			// ��װû�е�����
			// UID---------string
			user.setUid(CommonsUtil.getUUID());
			// telephone-------string
			user.setTelephone(null);
			// state-------�Ƿ񼤻�------int
			user.setState(0);
			// code------������-------String
			String activeCode = CommonsUtil.getUUID();
			user.setCode(activeCode);

			// ��������
			UserService service = new UserService();
			boolean isRegisterSuccess = service.register(user);
			// �ض���----�ж��Ƿ����ɹ�
			if (isRegisterSuccess == true) {
				// ����ɹ�
				// �����ʼ�
				MailUtils.sendMail(user.getEmail(),
						"��ϲ��ע��ɹ���������������ӽ��м����˻�" + "<a href='http://localhost/Shop/user?methodName=active&activeCode=" + activeCode
								+ "'>" + "http://localhost/Shop/user?methodName=active&activeCode=" + activeCode + "</a>");
				// ��ת��ע��ɹ�ҳ��
				response.sendRedirect(request.getContextPath() + "/registerSuccess.jsp");
				return;
			} else {
				// ����ʧ��----��ת��ע��ʧ��ҳ��
				response.sendRedirect(request.getContextPath() + "/registerFail.jsp");
				return;
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	
	public void exit(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String exit ="true";
		HttpSession session = request.getSession();
		session.setAttribute("exit", exit);
		session.removeAttribute("user");
		//�ض�����ҳ
		response.sendRedirect(request.getContextPath()+"/login.jsp");
	}
	
}