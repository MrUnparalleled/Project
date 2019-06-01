package com._520it.dao;

import java.sql.SQLException;

import org.apache.commons.dbutils.QueryRunner;
import org.apache.commons.dbutils.handlers.BeanHandler;
import org.apache.commons.dbutils.handlers.ScalarHandler;

import com._520it.domain.User;
import com._520it.util.DataSourceUtils;

public class UserDao {

	public int register(User user) throws SQLException {
		QueryRunner runner =new QueryRunner(DataSourceUtils.getDataSource());
		String sql ="insert into user values(?,?,?,?,?,?,?,?,?,?)";
		int rows = runner.update(sql, user.getUid(),user.getUsername(),
				user.getPassword(),user.getName(),user.getEmail(),
				user.getTelephone(),user.getBirthday(),user.getSex(),
				user.getState(),user.getCode());
		
		return rows;
		
	}
	
	
	/**
	 * º§ªÓ’Àªß 
	 * @param activeCode
	 * @throws SQLException 
	 */
	public void active(String activeCode) throws SQLException {
		QueryRunner runner = new QueryRunner(DataSourceUtils.getDataSource());
		String sql ="update user set state=? where code=?";
		runner.update(sql, 1,activeCode);
	}


	public Long checkUser(String username) throws SQLException {
		QueryRunner runner = new QueryRunner(DataSourceUtils.getDataSource());
		String sql ="select count(*) from user where username=?";
		Long count = (Long) runner.query(sql, new ScalarHandler(), username);
		return count;
	}


	public User login(String username, String password) throws SQLException {
		QueryRunner runner = new QueryRunner(DataSourceUtils.getDataSource());
		String sql ="select * from user where username=? and password=? and state=1";
		User user = runner.query(sql, new BeanHandler<User>(User.class), username,password);
		return user;
	}

}
