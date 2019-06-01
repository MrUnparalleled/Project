package com._520it.dao;

import java.sql.SQLException;
import java.util.List;
import java.util.Map;

import org.apache.commons.dbutils.QueryRunner;
import org.apache.commons.dbutils.handlers.BeanHandler;
import org.apache.commons.dbutils.handlers.BeanListHandler;
import org.apache.commons.dbutils.handlers.MapListHandler;

import com._520it.domain.Category;
import com._520it.domain.Order;
import com._520it.domain.Product;
import com._520it.util.DataSourceUtils;

public class AdminDao {

	public List<Product> findAllProduct() throws SQLException {
		QueryRunner runner = new QueryRunner(DataSourceUtils.getDataSource());
		String sql = "select * from product";
		List<Product> list = runner.query(sql, new BeanListHandler<Product>(Product.class));
		return list;
	}

	public List<Category> findAllCategory() throws SQLException {
		QueryRunner runner = new QueryRunner(DataSourceUtils.getDataSource());
		String sql = "select * from category";
		List<Category> list = runner.query(sql, new BeanListHandler<Category>(Category.class));
		return list;
	}

	public void addProduct(Product product) throws SQLException {
		QueryRunner runner = new QueryRunner(DataSourceUtils.getDataSource());
		String sql = "insert into product values(?,?,?,?,?,?,?,?,?,?)";
		runner.update(sql, product.getPid(), product.getPname(), product.getMarket_price(), product.getShop_price(),
				product.getPimage(), product.getPdate(), product.getIs_hot(), product.getPdesc(), product.getPflag(),
				product.getCid());
	}

	public void editProduct(Product product) throws Exception {
		QueryRunner runner = new QueryRunner(DataSourceUtils.getDataSource());
		String sql = "update product set pname=?,market_price=?,shop_price=?,pimage=?,pdate=?,is_hot=?,pdesc=?,pflag=?,cid=? where pid=?";
		runner.update(sql, product.getPname(), product.getMarket_price(), product.getShop_price(), product.getPimage(),
				product.getPdate(), product.getIs_hot(), product.getPdesc(), product.getPflag(), product.getCid(),
				product.getPid());
	}

	public Product productEditUI(String pid) throws SQLException {
		QueryRunner runner = new QueryRunner(DataSourceUtils.getDataSource());
		String sql="select * from product where pid=?";
		Product query = (Product) runner.query(sql, new BeanHandler<Product>(Product.class),pid);
		return query;
	}

	public List<Order> orderList() throws SQLException {
		QueryRunner runner = new QueryRunner(DataSourceUtils.getDataSource());
		String sql="select * from orders";
		List<Order> order = runner.query(sql, new BeanListHandler<Order>(Order.class));
		return order;
	}

	public List<Map<String, Object>> orderMessage(String oid) throws SQLException {
		QueryRunner runner = new QueryRunner(DataSourceUtils.getDataSource());
		String sql="select o.count,o.subtotal,p.pimage,p.pname,p.shop_price from orderitem o,product p where o.pid=p.pid and o.oid=?";
		List<Map<String, Object>> query = runner.query(sql, new MapListHandler(), oid);
		return query;
	}

	/*
	 * 删除商品类别
	 */
	public int delCategory(String cid) throws SQLException {
		// TODO Auto-generated method stub
		QueryRunner runner =new QueryRunner(DataSourceUtils.getDataSource());
		String sql ="delete from category where cid=?";
		int update = runner.update(sql, cid);
		return update;
	}

	/*
	 * 删除商品
	 */
	public int delProduct(String pid) throws SQLException {
		QueryRunner runner =new QueryRunner(DataSourceUtils.getDataSource());
		String sql ="delete from product where pid=?";
		int update = runner.update(sql, pid);
		return update;
	}

	public int addCategory(Category category) throws SQLException {
		QueryRunner runner =new QueryRunner(DataSourceUtils.getDataSource());
		String sql = "insert into category values(?,?)";
		int update = runner.update(sql, category.getCid(),category.getCname());
		return update;
	}

}
