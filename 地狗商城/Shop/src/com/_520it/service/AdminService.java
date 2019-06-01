package com._520it.service;

import java.sql.SQLException;
import java.util.List;
import java.util.Map;

import com._520it.dao.AdminDao;
import com._520it.domain.Category;
import com._520it.domain.Order;
import com._520it.domain.OrderItem;
import com._520it.domain.Product;

public class AdminService {

	public List<Product> findAllProduct() {
		//传递请求和参数
		AdminDao dao =new AdminDao();
		List<Product> productList=null;
		try {
			productList = dao.findAllProduct();
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return productList;
	}

	public List<Category> findAllCategory() {
		//传递请求
		AdminDao dao =new AdminDao();
		List<Category> categoryList=null;
		try {
			categoryList = dao.findAllCategory();
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return categoryList;
	}

	/***
	 * 添加商品
	 * @param product
	 */
	public void addProduct(Product product) {
		AdminDao dao =new AdminDao();
		try {
			dao.addProduct(product);
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public void editProduct(Product product) {
		AdminDao dao =new AdminDao();
		try {
			dao.editProduct(product);
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	public Product productEditUI(String pid) {
		//传递请求和参数
		AdminDao dao =new AdminDao();
		Product list = null;
		try {
			 list = dao.productEditUI(pid);
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return list;
	}

	public List<Order> orderList() {
		//传递请求参数
		AdminDao dao = new AdminDao();
		List<Order> order=null;
		try {
			order = dao.orderList();
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return order;
	}

	public List<Map<String, Object>> orderMessage(String oid) {
		AdminDao dao =new AdminDao();
		List<Map<String, Object>> orderMessage=null;
		try {
			orderMessage = dao.orderMessage(oid);
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return orderMessage;
	}

	/*
	 * 删除商品类别
	 */
	public void delCategory(String cid)  {
		AdminDao dao =new AdminDao();
		try {
			int i = dao.delCategory(cid);
			if (i>0) {
				System.out.println("删除成功");
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	/*
	 * 删除商品
	 */
	public void delProduct(String pid) {
		AdminDao dao =new AdminDao();
		try {
			int update = dao.delProduct(pid);
			if (update>0) {
				System.out.println("删除成功");
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	/**
	 * 添加商品类别
	 * @param category
	 */
	public void addCategory(Category category) {
		AdminDao dao =new AdminDao();
		try {
			int update = dao.addCategory(category);
			if (update>0) {
				System.out.println("添加成功");
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

}
