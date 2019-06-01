package com._520it.service;

import java.sql.SQLException;
import java.util.List;
import java.util.Map;

import com._520it.dao.ProductDao;
import com._520it.domain.Category;
import com._520it.domain.Order;
import com._520it.domain.PageBean;
import com._520it.domain.Product;
import com._520it.util.DataSourceUtils;

public class ProductService {

	/**
	 * 获取最新商品
	 * @return
	 */
	public List<Product> findNewProduct() {
		//传递请求和参数到dao层
		ProductDao dao =new ProductDao();
		List<Product> list=null;
		try {
			list = dao.findNewProduct();
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return list;
	}

	/**
	 * 获取最热商品
	 * @return
	 */
	public List<Product> findHotProduct() {
		//传递请求和参数到dao层
		ProductDao dao =new ProductDao();
		List<Product> list=null;
		try {
			list = dao.findHotProduct();
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return list;
	}

	//获得所有商品类别的信息
	public List<Category> findAllCategory() {
		ProductDao dao = new ProductDao();
		List<Category> list =null;
		try {
			list = dao.findAllCategory();
		} catch (SQLException e) {
			e.printStackTrace();
		}
		
		return list;
	}

	public PageBean<Product> findProductByCid(String cid, int currentPage, int currentProduct) {
		
		//创建一个PageBean
		PageBean<Product> pageBean =new PageBean<Product>();
		ProductDao dao =new ProductDao();
		//总商品数
		int totalProduct=0;
		try {
			totalProduct = dao.finProductNumBycid(cid);
		} catch (SQLException e) {
			e.printStackTrace();
		}
		pageBean.setTotalProduct(totalProduct);
		//总页数
		int totalPage =(int) Math.ceil((1.0*totalProduct)/currentProduct);
		pageBean.setTotalPage(totalPage);
		//当前页号
		pageBean.setCurrentPage(currentPage);
		//当前页商品数
		pageBean.setCurrentProduct(currentProduct);
		//当前页商品
		List<Product> currentProductList=null;
		try {
			currentProductList = dao.findProductByCid(cid,currentPage,currentProduct);
		} catch (SQLException e) {
			e.printStackTrace();
		}
		pageBean.setCurrentProductList(currentProductList);
		
		
		return pageBean;
	}

	public Product findProductByPid(String pid) {
		//传递参数和请求到dao层
		ProductDao dao = new ProductDao();
		Product product = null;
		try {
			product = dao.findProductByPid(pid);
		} catch (SQLException e) {
			e.printStackTrace();
		}
		
		return product;
	}

	/**
	 * 根据pid查询历史商品信息
	 * @param pid
	 * @return
	 */
	public Product findHistoryProduct(String pid) {
		ProductDao dao = new ProductDao();
		Product product =null;
		try {
			product = dao.findProductByPid(pid);
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return product;
	}

	/**
	 * 提交订单
	 * @param order
	 */
	
	@SuppressWarnings("finally")
	public int submitOrder(Order order) {
		int i=1;
		try {
			ProductDao dao =new ProductDao();
			//打开事务
			DataSourceUtils.startTransaction();
			//向order表中插入数据
			dao.insertOrder(order);
			//向orderItem表中插入数据
			dao.insertOrderItem(order);
		} catch (SQLException e) {
			try {
				DataSourceUtils.rollback();
				i=0;
			} catch (SQLException e1) {
				e1.printStackTrace();
			}
			e.printStackTrace();
		}finally {
			try {
				DataSourceUtils.commitAndRelease();
			} catch (SQLException e) {
				e.printStackTrace();
			}
			return i;
		}
	}

	public int updateAddr(Order order) {
		ProductDao dao =new ProductDao();
		int updateAddr=0;
		try {
			updateAddr = dao.updateAddr(order);
		} catch (SQLException e) {
			e.printStackTrace();
		}
		
		return updateAddr;
		
	}

	public List<Order> findOrderByUid(String uid) {
		ProductDao dao =new ProductDao();
		List<Order> orders=null;
		try {
			orders = dao.findOrderByUid(uid);
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return orders;
	}

	public List<Map<String, Object>> findOrderItemByOid(String oid) {
		ProductDao dao =new ProductDao();
		List<Map<String, Object>> list=null;
		try {
			list = dao.findOrderItemByOid(oid);
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return list;
	}

	public List<Product> searchWord(String word) {
		ProductDao dao =new ProductDao();
		List<Product> list =null;
		try {
			 list = dao.searchWord(word);
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return list;
	}

}
