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
	 * ʵ����Ʒ�ർ��---��ѯ��Ʒ��
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void allCategory(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		ProductService service =new ProductService();
		//System.out.println("--------------");
		//�ȴӻ����в�ѯ���ݣ����û�еĻ��ʹ����ݿ⵱�в�ѯ���ݲ��ҽ���ѯ���������ݷŵ����浱��
		Jedis jedis = JedisPoolUtils.getJedis();
		String categoryListJson = jedis.get("categoryListJson");
		//System.out.println(categoryListJson);
		if (categoryListJson==null) {
			System.out.println("������û�����ݣ������ݿ⵱�в�ѯ����");
			//׼�����е�category
			List<Category> categoryList =service.findAllCategory();
			Gson gson=new Gson();
			categoryListJson = gson.toJson(categoryList);
			jedis.set("categoryListJson", categoryListJson);
		}
		response.getWriter().write(categoryListJson);
	}
	
	/**
	 * ʵ����ҳ----������Ʒ��������Ʒ
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void index(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		ProductService service =new ProductService();
		//׼��������Ʒ
		List<Product> newProductList = service.findNewProduct();
		request.setAttribute("newProductList", newProductList);
		//׼��������Ʒ
		List<Product> hotProductList = service.findHotProduct();
		request.setAttribute("hotProductList", hotProductList);
		
		//����ת��
		request.getRequestDispatcher("/index.jsp").forward(request, response);
	}
	
	/**
	 * ʵ����Ʒ��ϸ��Ϣ
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void productInfo(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//��ȡ��ǰҳ��currentPage
				String currentPage = request.getParameter("currentPage");
				//��ȡ��Ʒ���cid
				String cid = request.getParameter("cid");
				//��ȡ����pid
				String pid = request.getParameter("pid");
				ProductService service =new ProductService();
				Product product = service.findProductByPid(pid);
				//�����ݷŵ�request����
				request.setAttribute("product", product);
				request.setAttribute("cid", cid);
				request.setAttribute("currentPage", currentPage);
				
				//��ÿͻ���Я��cookie-----�������Ϊpids��cookie
				String pids=pid;
				Cookie[] cookies = request.getCookies();
				if (cookies!=null) {
					for (Cookie cookie : cookies) {
						if ("pids".equals(cookie.getName())) {
							pids=cookie.getValue();
							//1&2&3���η��ʵ���Ʒ��8--------->8&1&2&3
							//1&2&3���η��ʵ���Ʒ��3--------->3&1&2
							//��pids���һ������
							String[] split = pids.split("&");//{3,1,2}
							List<String> asList = Arrays.asList(split);//[3,1,2]
							LinkedList<String> list =new LinkedList<String>(asList);//{3,1,2}
							//�ж�����������Ƿ���ڵ�ǰ��pid
							if (list.contains(pid)) {
								//������ǰ�鿴��Ʒ��pid
								list.remove(pid);
							}
							//����ǰ��pid�ŵ�ͷ��
							list.addFirst(pid);
							//������ת�����ַ���
							StringBuffer sBuffer =new StringBuffer();
							for (int i = 0; i < list.size()&&i<7; i++) {
								sBuffer.append(list.get(i));
								sBuffer.append("&");//3&1&2&
							}
							//ȥ��3&1&2&�����&
							pids=sBuffer.substring(0,sBuffer.length()-1);
							
							
						}
					}
				}
				Cookie cookie_pids =new Cookie("pids", pids);
				response.addCookie(cookie_pids);
				
				//����ת��
				request.getRequestDispatcher("/product_info.jsp").forward(request, response);
	}
	
	/**
	 * ʵ�ַ�����Ʒչʾ
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void productList(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//���cid
				String cid = request.getParameter("cid");
				//��ȡ��ǰҳ
				String currentPagestr = request.getParameter("currentPage");
				int currentPage=1;
				if (currentPagestr!=null) {
					currentPage = Integer.parseInt(currentPagestr);
				}
				//���õ�ǰҳ��Ʒ��
				int currentProduct =12;
				//����cid��ȡpageBean����
				ProductService service =new ProductService();
				PageBean<Product> pageBeans = service.findProductByCid(cid,currentPage,currentProduct);
				request.setAttribute("cid", cid);
				request.setAttribute("pageBeans", pageBeans);
				//��ת��֮ǰ��������¼����Ʒ��Ϣ
				//���cookieЯ��������Ϊpids��cookie
				List<Product> historyProductList =new ArrayList<Product>();
				Cookie[] cookies = request.getCookies();
				for (Cookie cookie : cookies) {
					if (cookie!=null) {
						if ("pids".equals(cookie.getName())) {
							//��
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
				
				//����ת��
				request.getRequestDispatcher("/product_list.jsp").forward(request, response);
	}

	/**
	 * ���빺�ﳵ
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
		//��������----pid��buyNum
		String pid = request.getParameter("pid");
		int buyNum = Integer.parseInt(request.getParameter("buyNum"));
		//���product
		Product product = service.findProductByPid(pid);
		//���㹺����Ľ��
		double money =product.getShop_price()*buyNum;
		//�ж�session�����Ƿ��Ѿ����˹��ﳵ
		cart = (Cart) session.getAttribute("cart");
		if (cart==null) {
			cart=new Cart();
		}
		//�жϹ��ﳵ�����Ƿ�����˵�ǰ��Ʒ
		Map<String, CartItem> cartItems = cart.getCartItems();
		if (cartItems.containsKey(pid)) {
			//����
			cartItem=cartItems.get(pid);
			buyNum+=cartItem.getBuyNum();
			moneyAll=money+cartItem.getMoney();
		}else {
			//������
			cartItem=new CartItem();
			moneyAll=money;
		}
		//�����ݷŵ�����������
		cartItem.setBuyNum(buyNum);
		cartItem.setProduct(product);
		cartItem.setMoney(moneyAll);
		cartItems.put(pid, cartItem);
		
		double totalMoney =cart.getTotalMoney()+money;
		cart.setTotalMoney(totalMoney);
		cart.setCartItems(cartItems);
		session.setAttribute("cart", cart);
		//===============================
		
		//=========�ض���======================
		response.sendRedirect(request.getContextPath()+"/cart.jsp");
		
	}
	
	
	/**
	 * �ӹ��ﳵ����ɾ��ĳ����Ʒ
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void delProductFromCart(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//��������
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
		//�ض���
		response.sendRedirect(request.getContextPath()+"/cart.jsp");
	}
	
	/**
	 * ��չ��ﳵ
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
		//�ض���
		response.sendRedirect(request.getContextPath()+"/cart.jsp");
	}
	
	/**
	 * �ύ����
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void submitOrder(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		ProductService service =new ProductService();
		//�жϵ�ǰ�Ƿ��ѵ�¼-------�鿴session�����Ƿ���user
		HttpSession session = request.getSession();
		User user = (User) session.getAttribute("user");
		if (user==null) {
			response.sendRedirect(request.getContextPath()+"/login.jsp");
			return;
		}
		//=============�Ѿ���¼==============
		//ȡ��session���е�cart---���ﳵ-----�жϹ��ﳵ�Ƿ�Ϊ��
		Cart cart = (Cart) session.getAttribute("cart");
		if (cart==null) {
			response.sendRedirect(request.getContextPath()+"/cart.jsp");
			return;
		}
		//��װorder����
		Order order =new Order();
		//�������private String oid;
		order.setOid(CommonsUtil.getUUID());
		//�µ�ʱ��private Date ordertime;
		order.setOrdertime(new Date());
		//�����ܼ�private double total;
		order.setTotal(cart.getTotalMoney());
		//����֧��״̬-------1�����Ѹ���-----0����δ����private int state;
		order.setState(0);
		//�ջ���ַprivate String address;
		order.setAddress(null);
		//�ջ�������private String name;
		order.setName(null);
		//�ջ��˵绰private String telephone;
		order.setTelephone(null);
		//�����������û�private User user;
		order.setUser(user);
		//�ö������еĶ�����private List<OrderItem> orderItems = new ArrayList<OrderItem>();
		//��ù��ﳵ�ڵĹ������
		Map<String, CartItem> cartItems = cart.getCartItems();
		for (Map.Entry<String, CartItem> entry : cartItems.entrySet()) {
			CartItem cartItem = entry.getValue();
			OrderItem orderItem =new OrderItem();
			//��װorderItem
			//1).��������private String itemid;
			orderItem.setItemid(CommonsUtil.getUUID());
			//2).��������Ʒ����private int count;
			orderItem.setCount(cartItem.getBuyNum());
			//3).������С��private double subtotal;
			orderItem.setSubtotal(cartItem.getMoney());
			//4).���������Ʒprivate Product product;
			orderItem.setProduct(cartItem.getProduct());
			//5).�ö����������ĸ�����private Order order;
			orderItem.setOrder(order);
			
			//��װ���---���뵽order����
			order.getOrderItems().add(orderItem);
		}
		//==============ȫ����װ���============
		//�����Ͷ�������Ϣ�ύ�����ݿ⵱��
		int success = service.submitOrder(order);
		if (success==1) {
			session.setAttribute("order", order);
			//=============ɾ��session�е�cart����===========
			cart.getCartItems().clear();
			cart.setTotalMoney(0);
			session.setAttribute("cart", cart);
			//==========================================
			response.sendRedirect(request.getContextPath()+"/order_info.jsp");
		}
	}
	
	
	/**
	 * ȷ�϶���
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void confirmOrder(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//��order��Ϣ���µ����ݿ�
		//���ղ���
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
			//���ݿ���³ɹ�
			
		}
		//ʵ��֧������
	
	}
	
	
	/**
	 * �ҵĶ�������ʵ��
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void myOrders(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//�鿴��ǰ�û��Ƿ��Ѿ���¼---�鿴session�����Ƿ���user----���Էŵ�filter����
		HttpSession session = request.getSession();
		User user = (User) session.getAttribute("user");
		if (user==null) {
			response.sendRedirect(request.getContextPath()+"/login.jsp");
			return;
		}
		//==================�Ѿ���¼================
		//�鵱ǰ�û���order
		ProductService service =new ProductService();
		List<Order> orders = service.findOrderByUid(user.getUid());
		if (orders!=null) {
			//����orders
			for (Order order : orders) {
				//���ÿ��������oid
				String oid = order.getOid();
				//����oid��ѯ���еĶ�����
				List<Map<String, Object>> list = service.findOrderItemByOid(oid);
				//ÿһ��map����һ������
				if (list!=null) {
					for (Map<String, Object> map : list) {
						try {
							//����Ϣ����orderitem
							OrderItem orderItem =new OrderItem();
							BeanUtils.populate(orderItem, map);
							//����Ϣ����product
							Product product =new Product();
							BeanUtils.populate(product, map);
							//��product����orderitem
							orderItem.setProduct(product);
							//��orderitem����order����
							order.getOrderItems().add(orderItem);
						} catch (Exception e) {
							e.printStackTrace();
						}
					}
				}
			}
		}
		//��orders�ŵ����У�����ת����order_list.jsp
		request.setAttribute("orders", orders);
		request.getRequestDispatcher("/order_list.jsp").forward(request, response);
	}
	
	
	public void searchWord(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//���ajax�Ĳ���
		String word = request.getParameter("word");
		
		//��ѯ���Ƶ���Ʒ
		ProductService service =new ProductService();
		List<Product> productList =null;
		productList = service.searchWord(word);
		Gson gson = new Gson();
		String json = gson.toJson(productList);
		response.getWriter().write(json);
	
	}
}


