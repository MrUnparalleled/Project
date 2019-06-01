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
		//��������Ͳ���
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
		//��������
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
	 * �����Ʒ
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
		//��������Ͳ���
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
		//�����������
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
	 * ɾ����Ʒ���
	 */
	public void delCategory(String cid)  {
		AdminDao dao =new AdminDao();
		try {
			int i = dao.delCategory(cid);
			if (i>0) {
				System.out.println("ɾ���ɹ�");
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	/*
	 * ɾ����Ʒ
	 */
	public void delProduct(String pid) {
		AdminDao dao =new AdminDao();
		try {
			int update = dao.delProduct(pid);
			if (update>0) {
				System.out.println("ɾ���ɹ�");
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	/**
	 * �����Ʒ���
	 * @param category
	 */
	public void addCategory(Category category) {
		AdminDao dao =new AdminDao();
		try {
			int update = dao.addCategory(category);
			if (update>0) {
				System.out.println("��ӳɹ�");
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

}
