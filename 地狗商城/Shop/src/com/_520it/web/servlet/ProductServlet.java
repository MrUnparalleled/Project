package com._520it.web.servlet;

import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Date;
import java.util.LinkedList;
import java.util.List;
import java.util.Map;

import javax.servlet.ServletException;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import org.apache.commons.beanutils.BeanUtils;

import com._520it.domain.Cart;
import com._520it.domain.CartItem;
import com._520it.domain.Category;
import com._520it.domain.Order;
import com._520it.domain.OrderItem;
import com._520it.domain.PageBean;
import com._520it.domain.Product;
import com._520it.domain.User;
import com._520it.service.ProductService;
import com._520it.util.CommonsUtil;
import com._520it.util.JedisPoolUtils;
import com.google.gson.Gson;

import redis.clients.jedis.Jedis;

public class ProductServlet extends BaseServlet {

//	public void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
//		String methodName = request.getParameter("methodName");
//		//System.out.println(methodName);
//		if (methodName.equals("allCategory")) {
//			allCategory(request,response);
//		}else if (methodName.equals("index")) {
//			index(request,response);
//		}else if (methodName.equals("productInfo")) {
//			productInfo(request,response);
//		}else if (methodName.equals("productList")) {
//			productList(request,response);
//		}
//	}
//
//	public void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
//		doGet(request, response);
//	}
	/**
	 * 实现商品类导航---查询商品类
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void allCategory(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		ProductService service =new ProductService();
		//System.out.println("--------------");
		//先从缓存中查询数据，如果没有的话就从数据库当中查询数据并且将查询出来的数据放到缓存当中
		Jedis jedis = JedisPoolUtils.getJedis();
		String categoryListJson = jedis.get("categoryListJson");
		//System.out.println(categoryListJson);
		if (categoryListJson==null) {
			System.out.println("缓存中没有数据，从数据库当中查询数据");
			//准备所有的category
			List<Category> categoryList =service.findAllCategory();
			Gson gson=new Gson();
			categoryListJson = gson.toJson(categoryList);
			jedis.set("categoryListJson", categoryListJson);
		}
		response.getWriter().write(categoryListJson);
	}
	
	/**
	 * 实现首页----最热商品和最新商品
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void index(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		ProductService service =new ProductService();
		//准备最新商品
		List<Product> newProductList = service.findNewProduct();
		request.setAttribute("newProductList", newProductList);
		//准备最热商品
		List<Product> hotProductList = service.findHotProduct();
		request.setAttribute("hotProductList", hotProductList);
		
		//请求转发
		request.getRequestDispatcher("/index.jsp").forward(request, response);
	}
	
	/**
	 * 实现商品详细信息
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void productInfo(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//获取当前页号currentPage
				String currentPage = request.getParameter("currentPage");
				//获取商品类别cid
				String cid = request.getParameter("cid");
				//获取参数pid
				String pid = request.getParameter("pid");
				ProductService service =new ProductService();
				Product product = service.findProductByPid(pid);
				//将数据放到request域当中
				request.setAttribute("product", product);
				request.setAttribute("cid", cid);
				request.setAttribute("currentPage", currentPage);
				
				//获得客户端携带cookie-----获得名字为pids的cookie
				String pids=pid;
				Cookie[] cookies = request.getCookies();
				if (cookies!=null) {
					for (Cookie cookie : cookies) {
						if ("pids".equals(cookie.getName())) {
							pids=cookie.getValue();
							//1&2&3本次访问的商品是8--------->8&1&2&3
							//1&2&3本次访问的商品是3--------->3&1&2
							//将pids拆成一个数组
							String[] split = pids.split("&");//{3,1,2}
							List<String> asList = Arrays.asList(split);//[3,1,2]
							LinkedList<String> list =new LinkedList<String>(asList);//{3,1,2}
							//判断这个集合中是否存在当前的pid
							if (list.contains(pid)) {
								//包含当前查看商品的pid
								list.remove(pid);
							}
							//将当前的pid放到头上
							list.addFirst(pid);
							//将集合转换成字符串
							StringBuffer sBuffer =new StringBuffer();
							for (int i = 0; i < list.size()&&i<7; i++) {
								sBuffer.append(list.get(i));
								sBuffer.append("&");//3&1&2&
							}
							//去掉3&1&2&后面的&
							pids=sBuffer.substring(0,sBuffer.length()-1);
							
							
						}
					}
				}
				Cookie cookie_pids =new Cookie("pids", pids);
				response.addCookie(cookie_pids);
				
				//请求转发
				request.getRequestDispatcher("/product_info.jsp").forward(request, response);
	}
	
	/**
	 * 实现分类商品展示
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void productList(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//获得cid
				String cid = request.getParameter("cid");
				//获取当前页
				String currentPagestr = request.getParameter("currentPage");
				int currentPage=1;
				if (currentPagestr!=null) {
					currentPage = Integer.parseInt(currentPagestr);
				}
				//设置当前页商品数
				int currentProduct =12;
				//根据cid获取pageBean对象
				ProductService service =new ProductService();
				PageBean<Product> pageBeans = service.findProductByCid(cid,currentPage,currentProduct);
				request.setAttribute("cid", cid);
				request.setAttribute("pageBeans", pageBeans);
				//在转发之前获得浏览记录的商品信息
				//获得cookie携带的名字为pids的cookie
				List<Product> historyProductList =new ArrayList<Product>();
				Cookie[] cookies = request.getCookies();
				for (Cookie cookie : cookies) {
					if (cookie!=null) {
						if ("pids".equals(cookie.getName())) {
							//拆串
							String pids = cookie.getValue();
							String[] split = pids.split("&");
							for (String pid : split) {
								Product product = service.findHistoryProduct(pid);
								historyProductList.add(product);
							}
						}
					}
				}
				request.setAttribute("historyProductList", historyProductList);
				
				//请求转发
				request.getRequestDispatcher("/product_list.jsp").forward(request, response);
	}

	/**
	 * 加入购物车
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void addProductToCart(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		HttpSession session = request.getSession();
		ProductService service =new ProductService();
		Cart cart = null;
		CartItem cartItem=null;
		double moneyAll=0;
		//接收数据----pid和buyNum
		String pid = request.getParameter("pid");
		int buyNum = Integer.parseInt(request.getParameter("buyNum"));
		//获得product
		Product product = service.findProductByPid(pid);
		//计算购物项的金额
		double money =product.getShop_price()*buyNum;
		//判断session当中是否已经有了购物车
		cart = (Cart) session.getAttribute("cart");
		if (cart==null) {
			cart=new Cart();
		}
		//判断购物车当中是否包含了当前商品
		Map<String, CartItem> cartItems = cart.getCartItems();
		if (cartItems.containsKey(pid)) {
			//包含
			cartItem=cartItems.get(pid);
			buyNum+=cartItem.getBuyNum();
			moneyAll=money+cartItem.getMoney();
		}else {
			//不包含
			cartItem=new CartItem();
			moneyAll=money;
		}
		//将数据放到购物项里面
		cartItem.setBuyNum(buyNum);
		cartItem.setProduct(product);
		cartItem.setMoney(moneyAll);
		cartItems.put(pid, cartItem);
		
		double totalMoney =cart.getTotalMoney()+money;
		cart.setTotalMoney(totalMoney);
		cart.setCartItems(cartItems);
		session.setAttribute("cart", cart);
		//===============================
		
		//=========重定向======================
		response.sendRedirect(request.getContextPath()+"/cart.jsp");
		
	}
	
	
	/**
	 * 从购物车里面删除某件商品
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void delProductFromCart(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//接收数据
		String pid = request.getParameter("pid");
		HttpSession session = request.getSession();
		Cart cart = (Cart) session.getAttribute("cart");
		if (cart!=null) {
			Map<String, CartItem> cartItems = cart.getCartItems();
			CartItem cartItem = cartItems.get(pid);
			double totalMoney =cart.getTotalMoney()-cartItem.getMoney();
			cart.setTotalMoney(totalMoney);
			cartItems.remove(pid);
			cart.setCartItems(cartItems);
		}
		//重定向
		response.sendRedirect(request.getContextPath()+"/cart.jsp");
	}
	
	/**
	 * 清空购物车
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void delAllProductFromCart(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		HttpSession session = request.getSession();
		Cart cart = (Cart) session.getAttribute("cart");
		cart.getCartItems().clear();
		cart.setTotalMoney(0);
		session.setAttribute("cart", cart);
		//重定向
		response.sendRedirect(request.getContextPath()+"/cart.jsp");
	}
	
	/**
	 * 提交订单
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void submitOrder(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		ProductService service =new ProductService();
		//判断当前是否已登录-------查看session当中是否有user
		HttpSession session = request.getSession();
		User user = (User) session.getAttribute("user");
		if (user==null) {
			response.sendRedirect(request.getContextPath()+"/login.jsp");
			return;
		}
		//=============已经登录==============
		//取出session当中的cart---购物车-----判断购物车是否为空
		Cart cart = (Cart) session.getAttribute("cart");
		if (cart==null) {
			response.sendRedirect(request.getContextPath()+"/cart.jsp");
			return;
		}
		//封装order对象
		Order order =new Order();
		//订单编号private String oid;
		order.setOid(CommonsUtil.getUUID());
		//下单时间private Date ordertime;
		order.setOrdertime(new Date());
		//订单总计private double total;
		order.setTotal(cart.getTotalMoney());
		//订单支付状态-------1代表已付款-----0代表未付款private int state;
		order.setState(0);
		//收货地址private String address;
		order.setAddress(null);
		//收货人姓名private String name;
		order.setName(null);
		//收货人电话private String telephone;
		order.setTelephone(null);
		//订单所属的用户private User user;
		order.setUser(user);
		//该订单所有的订单项private List<OrderItem> orderItems = new ArrayList<OrderItem>();
		//获得购物车内的购物项集合
		Map<String, CartItem> cartItems = cart.getCartItems();
		for (Map.Entry<String, CartItem> entry : cartItems.entrySet()) {
			CartItem cartItem = entry.getValue();
			OrderItem orderItem =new OrderItem();
			//封装orderItem
			//1).订单项编号private String itemid;
			orderItem.setItemid(CommonsUtil.getUUID());
			//2).订单的商品数量private int count;
			orderItem.setCount(cartItem.getBuyNum());
			//3).订单的小计private double subtotal;
			orderItem.setSubtotal(cartItem.getMoney());
			//4).订单项的商品private Product product;
			orderItem.setProduct(cartItem.getProduct());
			//5).该订单项属于哪个订单private Order order;
			orderItem.setOrder(order);
			
			//封装完毕---加入到order当中
			order.getOrderItems().add(orderItem);
		}
		//==============全部封装完毕============
		//订单和订单项信息提交到数据库当中
		int success = service.submitOrder(order);
		if (success==1) {
			session.setAttribute("order", order);
			//=============删除session中的cart数据===========
			cart.getCartItems().clear();
			cart.setTotalMoney(0);
			session.setAttribute("cart", cart);
			//==========================================
			response.sendRedirect(request.getContextPath()+"/order_info.jsp");
		}
	}
	
	
	/**
	 * 确认订单
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void confirmOrder(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//将order信息更新到数据库
		//接收参数
		Map<String, String[]> parameterMap = request.getParameterMap();
		//HttpSession session = request.getSession();
		Order order =new Order();
		try {
			BeanUtils.populate(order, parameterMap);
		} catch (Exception e) {
			e.printStackTrace();
		} 
		ProductService service =new ProductService();
		int updateAddr = service.updateAddr(order);
		if (updateAddr!=0) {
			//数据库更新成功
			
		}
		//实现支付功能
	
	}
	
	
	/**
	 * 我的订单功能实现
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void myOrders(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//查看当前用户是否已经登录---查看session当中是否有user----可以放到filter当中
		HttpSession session = request.getSession();
		User user = (User) session.getAttribute("user");
		if (user==null) {
			response.sendRedirect(request.getContextPath()+"/login.jsp");
			return;
		}
		//==================已经登录================
		//查当前用户的order
		ProductService service =new ProductService();
		List<Order> orders = service.findOrderByUid(user.getUid());
		if (orders!=null) {
			//遍历orders
			for (Order order : orders) {
				//获得每个订单的oid
				String oid = order.getOid();
				//根据oid查询所有的订单项
				List<Map<String, Object>> list = service.findOrderItemByOid(oid);
				//每一个map就是一条数据
				if (list!=null) {
					for (Map<String, Object> map : list) {
						try {
							//将信息封入orderitem
							OrderItem orderItem =new OrderItem();
							BeanUtils.populate(orderItem, map);
							//将信息封入product
							Product product =new Product();
							BeanUtils.populate(product, map);
							//将product放入orderitem
							orderItem.setProduct(product);
							//将orderitem放入order当中
							order.getOrderItems().add(orderItem);
						} catch (Exception e) {
							e.printStackTrace();
						}
					}
				}
			}
		}
		//将orders放到域当中，请求转发到order_list.jsp
		request.setAttribute("orders", orders);
		request.getRequestDispatcher("/order_list.jsp").forward(request, response);
	}
	
	
	public void searchWord(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//获得ajax的参数
		String word = request.getParameter("word");
		
		//查询相似的商品
		ProductService service =new ProductService();
		List<Product> productList =null;
		productList = service.searchWord(word);
		Gson gson = new Gson();
		String json = gson.toJson(productList);
		response.getWriter().write(json);
	
	}
}


