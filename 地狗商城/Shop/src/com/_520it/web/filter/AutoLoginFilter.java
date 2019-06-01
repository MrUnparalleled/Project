package com._520it.web.filter;

import java.io.IOException;

import javax.servlet.Filter;
import javax.servlet.FilterChain;
import javax.servlet.FilterConfig;
import javax.servlet.ServletException;
import javax.servlet.ServletRequest;
import javax.servlet.ServletResponse;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import com._520it.domain.User;
import com._520it.service.UserService;

public class AutoLoginFilter implements Filter {

	public void init(FilterConfig filterConfig) throws ServletException {

	}

	public void doFilter(ServletRequest request, ServletResponse response, FilterChain chain)
			throws IOException, ServletException {
		// ��cookie�е�autoLogin��user�ŵ�session����
		HttpServletRequest req = (HttpServletRequest) request;
		HttpServletResponse resp = (HttpServletResponse) response;
		String username = null;
		String password = null;
		Cookie[] cookies = req.getCookies();
		if (cookies != null) {
			for (Cookie cookie : cookies) {
				if (cookie.getName().equals("username")) {
					username = cookie.getValue();
				} else if (cookie.getName().equals("password")) {
					password = cookie.getValue();
				}
			}
		}

		// System.out.println(username);
		// System.out.println(password);
		// �ж�-----���ж��Ƿ��˳�
		HttpSession session = req.getSession();
		String exit = (String) session.getAttribute("exit");
		if (exit==null) {
			if (username != null && password != null) {
				// ��¼����
				UserService service = new UserService();
				User user = service.login(username, password);
				if (user != null) {
					session.setAttribute("user", user);
				}
			}
			// ����
			chain.doFilter(req, resp);
		} else {
			// ����
			chain.doFilter(req, resp);
		}
		

	}

	public void destroy() {

	}

}
