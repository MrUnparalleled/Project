package com._520it.web.servlet;

import java.io.IOException;
import java.lang.reflect.Method;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
@SuppressWarnings("all")//ѹ�ƾ���
public class BaseServlet extends HttpServlet {

	
	@Override
	protected void service(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
		
		try {
			//���������������
			req.setCharacterEncoding("UTF-8");
			resp.setContentType("text/html;charset=utf-8");
			//1.��������method������
			String methodName = req.getParameter("methodName");
			//2.��ȡ��ǰ�����ʵĶ�����ֽ������
			Class clazz = this.getClass();//ProductServlet.class
			//3.��õ�ǰ����ֽ����е�ָ������
			Method method =clazz.getMethod(methodName, HttpServletRequest.class,HttpServletResponse.class);
			//4.ִ����Ӧ�ķ���
			method.invoke(this, req,resp);
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
}