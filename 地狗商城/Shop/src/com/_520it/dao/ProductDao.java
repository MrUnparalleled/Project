package com._520it.dao;

import java.sql.SQLException;
import java.util.List;
import java.util.Map;

import org.apache.commons.dbutils.QueryRunner;
import org.apache.commons.dbutils.handlers.BeanHandler;
import org.apache.commons.dbutils.handlers.BeanListHandler;
import org.apache.commons.dbutils.handlers.MapListHandler;
import org.apache.commons.dbutils.handlers.ScalarHandler;

import com._520it.domain.Category;
import com._520it.domain.Order;
import com._520it.domain.OrderItem;
import com._520it.domain.Product;
import com._520it.util.DataSourceUtils;

public class ProductDao {

	/**
	 * 查询最新商品
	 * @return
	 * @throws SQLException
	 */
	public List<Product> findNewProduct() throws SQLException {

		QueryRunner runner =new QueryRunner(DataSourceUtils.getDataSource());
		String sql ="select * from product order by pdate desc limit?,?";
		List<Product> list = runner.query(sql, new BeanListHandler<Product>(Product.class), 0,9);
		return list;
	}

	/**
	 * 查询最热商品
	 * @return
	 * @throws SQLException
	 */
	public List<Product> findHotProduct() throws SQLException {
		QueryRunner runner =new QueryRunner(DataSourceUtils.getDataSource());
		String sql ="select * from product where is_hot=? limit?,?";
		List<Product> list = runner.query(sql, new BeanListHandler<Product>(Product.class), 1,0,9);
		return list;
	}

	/**
	 * 查询所有的商品类别
	 * @return
	 * @throws SQLException
	 */
	public List<Category> findAllCategory() throws SQLException {
		QueryRunner runner =new QueryRunner(DataSourceUtils.getDataSource());
		String sql ="select * from category";
		List<Category> list = runner.query(sql, new BeanListHandler<Category>(Category.class));
		return list;
	}

	/**
	 * 根据cid查询商品数量---分页
	 * @param cid
	 * @throws SQLException 
	 */
	public int finProductNumBycid(String cid) throws SQLException {
		QueryRunner runner =new QueryRunner(DataSourceUtils.getDataSource());
		String sql ="select count(*) from product where cid=?";
		Long query = (Long) runner.query(sql, new ScalarHandler(),cid);
		return query.intValue();
	}

	/**
	 * 根据cid查询商品---分页
	 * @param cid
	 * @param currentPage 
	 * @param currentProduct 
	 * @return
	 * @throws SQLException
	 */
	public List<Product> findProductByCid(String cid, int currentPage, int currentProduct) throws SQLException {
		QueryRunner runner =new QueryRunner(DataSourceUtils.getDataSource());
		String sql ="select * from product where cid=? limit ?,?";
		List<Product> list = runner.query(sql, new BeanListHandler<Product>(Product.class), cid,(currentPage-1)*currentProduct,currentProduct);
		return list;
	}
	
	/**
	 * 根据pid查询商品
	 * @param pid
	 * @return
	 * @throws SQLException
	 */
	public Product findProductByPid(String pid) throws SQLException {
		QueryRunner runner =new QueryRunner(DataSourceUtils.getDataSource());
		String sql ="select * from product where pid=?";
		Product product = runner.query(sql, new BeanHandler<Product>(Product.class), pid);
		return product;
	}

	/**
	 * 向order中插入数据
	 * @param order
	 * @throws SQLException 
	 */
	public void insertOrder(Order order) throws SQLException {
		QueryRunner runner =new QueryRunner();
		String sql ="insert into orders values(?,?,?,?,?,?,?,?)";
		runner.update(DataSourceUtils.getConnection(), sql, order.getOid(),order.getOrdertime(),
				order.getTotal(),order.getState(),order.getAddress(),order.getName(),
				order.getTelephone(),order.getUser().getUid());
	}

	/**
	 * 向orderItem表中插入数据
	 * @param order
	 * @throws SQLException 
	 */
	public void insertOrderItem(Order order) throws SQLException {
		QueryRunner runner =new QueryRunner();
		String sql ="insert into orderitem values(?,?,?,?,?)";
		List<OrderItem> orderItems = order.getOrderItems();
		for (OrderItem orderItem : orderItems) {
			runner.update(DataSourceUtils.getConnection(), sql,orderItem.getItemid(),orderItem.getCount(),
					orderItem.getSubtotal(),orderItem.getProduct().getPid(),orderItem.getOrder().getOid());
		}
	}

	public int updateAddr(Order order) throws SQLException {
		QueryRunner runner =new QueryRunner(DataSourceUtils.getDataSource());
		String sql = "update orders set address=? ,name=? , telephone=? where oid=?";
		int update = runner.update(sql, order.getAddress(),order.getName(),order.getTelephone(),order.getOid());
		return update;
		
	}

	public List<Order> findOrderByUid(String uid) throws SQLException {
		QueryRunner runner =new QueryRunner(DataSourceUtils.getDataSource());
		String sql ="select * from orders where uid=? order by ordertime desc";
		List<Order> list = runner.query(sql, new BeanListHandler<Order>(Order.class),uid);
		return list;
	}

	public List<Map<String, Object>> findOrderItemByOid(String oid) throws SQLException {
		QueryRunner runner =new QueryRunner(DataSourceUtils.getDataSource());
		String sql ="select * from orderitem o,product p where oid=? and o.pid=p.pid";
		List<Map<String,Object>> list = runner.query(sql,new MapListHandler() ,oid);
		return list;
	}

	public List<Product> searchWord(String word) throws SQLException {
		QueryRunner runner =new QueryRunner(DataSourceUtils.getDataSource());
		List<Product> list=null;
		String sql ="select * from product where 1=1";
		System.out.println(word);
		if(word!=null&&!word.trim().equals("")){
			sql+=" and pname like ? limit 0,5 ";
			list = runner.query(sql, new BeanListHandler<Product>(Product.class), "%"+word+"%");
		}
		return list;
	}


}
