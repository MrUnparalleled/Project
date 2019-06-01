package com._520it.service;

import java.sql.SQLException;

import com._520it.dao.UserDao;
import com._520it.domain.User;

public class UserService {

	/**
	 * ע���û�
	 * @param user
	 * @return
	 */
	public boolean register(User user) {
		//�������ݵ�dao��
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
	 * �����˻�
	 * @param activeCode
	 */
	public void active(String activeCode) {
		//���ݲ�����dao��
		UserDao dao =new UserDao();
		try {
			dao.active(activeCode);
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	/**
	 * ע��ǰ����û����Ƿ��Ѵ���
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
	 * ��¼��̨�û�������У��
	 * @param username
	 * @param password
	 * @return
	 */
	public User login(String username, String password) {
		//���ݲ���������dao��
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
