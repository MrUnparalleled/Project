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
	 * 激活账户
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void active(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// 获得激活码
		String activeCode = request.getParameter("activeCode");
		// 传递参数到service层
		UserService service = new UserService();
		service.active(activeCode);
		// 重定向到登录界面
		response.sendRedirect(request.getContextPath() + "/login.jsp");
	}

	/**
	 * 注册前检查用户名是否已存在
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void checkUsername(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		// 获取参数
		String username = request.getParameter("username");
		UserService service = new UserService();
		boolean isExist = service.checkUser(username);
		String json = "{\"isExist\":" + isExist + "}";
		response.getWriter().write(json);
	}

	
	/**
	 * 登录操作
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void login(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		// request.removeAttribute("loginInfo");
		// 检验验证码是否正确
		String checkCodeInfo="";
		HttpSession session = request.getSession();
		Object checkcode_session = session.getAttribute("checkcode_session");
		String checkCode = request.getParameter("checkCode");
		if (!checkCode.equals(checkcode_session)) {
			checkCodeInfo = "验证码有误";
			request.setAttribute("checkCodeInfo", checkCodeInfo);
			request.getRequestDispatcher("/login.jsp").forward(request, response);
			return;
		}

		// 获取参数
		String autoLogin = request.getParameter("autoLogin");
		//System.out.println(autoLogin);
		String username = request.getParameter("username");
		String password = request.getParameter("password");
		// 将参数和请求传到service层
		UserService service = new UserService();
		User user = service.login(username, password);
		if (user != null) {
			// 登录成功--重定向到主界面
			session.setAttribute("user", user);
			//如果选择自动登录,则将user传到cookie存起来
			if (autoLogin!=null) {
				//创建cookie
				Cookie cookie_username =new Cookie("username", username);
				Cookie cookie_password =new Cookie("password", password);
				//设置cookie的携带路径
				cookie_username.setPath(request.getContextPath());
				cookie_password.setPath(request.getContextPath());
				//设置cookie的持久化时间
				cookie_username.setMaxAge(60*60*24*3);
				cookie_password.setMaxAge(60*60*24*3);
				//发送cookie
				response.addCookie(cookie_username);
				response.addCookie(cookie_password);
			}
			//System.out.println(user);
			response.sendRedirect(request.getContextPath());
		} else {
			// 登录失败--请求转发到登录界面
			String loginInfo = "账号密码错误或账户未激活";
			request.setAttribute("loginInfo", loginInfo);
			request.getRequestDispatcher("login.jsp").forward(request, response);
		}
	}

	
	/**
	 * 用户注册
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void register(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
			
		try {
			// 判断验证码是否正确
			String checkCode = request.getParameter("checkCode");
			System.out.println(checkCode);
			HttpSession session = request.getSession();
			String checkcode_session = (String) session.getAttribute("checkcode_session");
			if (!checkCode.equals(checkcode_session)) {
				session.removeAttribute("checkcode_session");
				request.setAttribute("registerInfo", "验证码错误");
				request.getRequestDispatcher("/register.jsp").forward(request, response);
				return;
			}
			// 获取并封装数据
			Map<String, String[]> map = request.getParameterMap();
			User user = new User();
			// 自己指定一个类型转换器（将String转换成Date）
			ConvertUtils.register(new Converter() {
				public Object convert(Class arg0, Object arg1) {
					// 将String转换成date
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
			// 封装没有的数据
			// UID---------string
			user.setUid(CommonsUtil.getUUID());
			// telephone-------string
			user.setTelephone(null);
			// state-------是否激活------int
			user.setState(0);
			// code------激活码-------String
			String activeCode = CommonsUtil.getUUID();
			user.setCode(activeCode);

			// 传递数据
			UserService service = new UserService();
			boolean isRegisterSuccess = service.register(user);
			// 重定向----判断是否插入成功
			if (isRegisterSuccess == true) {
				// 插入成功
				// 发送邮件
				MailUtils.sendMail(user.getEmail(),
						"恭喜您注册成功，请点击下面的连接进行激活账户" + "<a href='http://localhost/Shop/user?methodName=active&activeCode=" + activeCode
								+ "'>" + "http://localhost/Shop/user?methodName=active&activeCode=" + activeCode + "</a>");
				// 跳转到注册成功页面
				response.sendRedirect(request.getContextPath() + "/registerSuccess.jsp");
				return;
			} else {
				// 插入失败----跳转到注册失败页面
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
		//重定向到首页
		response.sendRedirect(request.getContextPath()+"/login.jsp");
	}
	
}