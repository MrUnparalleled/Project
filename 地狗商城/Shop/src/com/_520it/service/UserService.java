package com._520it.service;

import java.sql.SQLException;

import com._520it.dao.UserDao;
import com._520it.domain.User;

public class UserService {

	/**
	 * 注册用户
	 * @param user
	 * @return
	 */
	public boolean register(User user) {
		//传递数据到dao层
		UserDao dao =new UserDao();
		int row=0;
		try {
			row = dao.register(user);
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return row>0?true:false;
		
	}
	
	/**
	 * 激活账户
	 * @param activeCode
	 */
	public void active(String activeCode) {
		//传递参数到dao层
		UserDao dao =new UserDao();
		try {
			dao.active(activeCode);
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	/**
	 * 注册前检查用户名是否已存在
	 * @param username
	 * @return
	 */
	public boolean checkUser(String username) {
		UserDao dao =new UserDao();
		Long count=0L;
		try {
			count = dao.checkUser(username);
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return count>0?true:false;
	}

	/**
	 * 登录后台用户名密码校验
	 * @param username
	 * @param password
	 * @return
	 */
	public User login(String username, String password) {
		//传递参数和请求到dao层
		User user =null;
		UserDao dao =new UserDao();
		try {
			user= dao.login(username,password);
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return user;
	}

}
