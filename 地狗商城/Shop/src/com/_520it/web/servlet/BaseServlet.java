package com._520it.web.servlet;

import java.io.IOException;
import java.lang.reflect.Method;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
@SuppressWarnings("all")//压制警告
public class BaseServlet extends HttpServlet {

	
	@Override
	protected void service(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
		
		try {
			//解决中文乱码问题
			req.setCharacterEncoding("UTF-8");
			resp.setContentType("text/html;charset=utf-8");
			//1.获得请求的method的名称
			String methodName = req.getParameter("methodName");
			//2.获取当前被访问的对象的字节码对象
			Class clazz = this.getClass();//ProductServlet.class
			//3.获得当前这个字节码中的指定方法
			Method method =clazz.getMethod(methodName, HttpServletRequest.class,HttpServletResponse.class);
			//4.执行相应的方法
			method.invoke(this, req,resp);
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
}