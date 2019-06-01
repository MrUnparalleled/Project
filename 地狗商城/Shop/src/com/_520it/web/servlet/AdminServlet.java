package com._520it.web.servlet;

import java.io.IOException;
import java.lang.reflect.InvocationTargetException;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.commons.beanutils.BeanUtils;

import com._520it.domain.Category;
import com._520it.domain.Order;
import com._520it.domain.OrderItem;
import com._520it.domain.Product;
import com._520it.service.AdminService;
import com._520it.util.CommonsUtil;
import com.google.gson.Gson;

public class AdminServlet extends BaseServlet {

	
	
	/**
	 * 后台商品信息列表
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void productList(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//传递请求
		AdminService service =new AdminService();
		List<Product> productList = service.findAllProduct();
		//将数据存到request域当中
		request.setAttribute("productList", productList);
		//System.out.println(productList);
		//请求转发
		request.getRequestDispatcher("/admin/product/list.jsp").forward(request, response);
	}
	
	/**
	 * 删除商品
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void delProduct(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//获取参数
		String pid = request.getParameter("pid");
		AdminService service =new AdminService();
		service.delProduct(pid);
		//System.out.println(pid);
		response.sendRedirect(request.getContextPath()+"/admin?methodName=productList");
	}
	/**
	 * 查找所有的商品类别
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void findAllCategory(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//传递请求
		AdminService service =new AdminService();
		List<Category> categoryList = service.findAllCategory();
		request.setAttribute("categoryList", categoryList);
		request.getRequestDispatcher("/admin/category/list.jsp").forward(request, response);
		
		//System.out.println(categoryList.toString());
		/*
		 * //将数据转换成json
		Gson gson =new Gson();
		String json = gson.toJson(categoryList);
		//System.out.println(json);
		response.getWriter().write(json);
		 */
		
		
	}
	
	/**
	 * 商品信息更新操作的准备工作
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void productEditUI(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//接收参数
		String pid = request.getParameter("pid");
		//传递请求和参数到service层
		AdminService service =new AdminService();
		Product product = service.productEditUI(pid);
		//将数据放到request域当中
		request.setAttribute("product", product);
		//请求转发
		request.getRequestDispatcher("/admin/product/edit.jsp").forward(request, response);
	}
	
	
	/**
	 * 订单详情
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void orderList(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//传递请求
		AdminService service =new AdminService();
		List<Order> orderList = service.orderList();
		request.setAttribute("orderList", orderList);
		request.getRequestDispatcher("/admin/order/list.jsp").forward(request, response);
	}

	/**
	 * 订单详情
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 * @throws InterruptedException 
	 */
	public void orderMessage(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException, InterruptedException {
		Thread.sleep(3000);
		//获取参数
		String oid = request.getParameter("oid");
		AdminService service =new AdminService();
		List<Map<String, Object>> orderItemList = service.orderMessage(oid);
		Gson gson =new Gson();
		String json = gson.toJson(orderItemList);
		response.getWriter().write(json);
	
	}
	
	/**
	 * 删除商品类别
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 * @throws InterruptedException
	 */
	public void delCategory(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException, InterruptedException {
		//获得参数--cid
		String cid = request.getParameter("cid");
		System.out.println(cid);
		AdminService service =new AdminService();
		service.delCategory(cid);
		request.getRequestDispatcher("/admin?method=findAllCategory").forward(request, response);
	}
	
	
	/**
	 * 添加商品类别
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 * @throws InterruptedException
	 */
	public void addCategory(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException, InterruptedException {
		//获得参数--cname
		Map<String, Object> parameterMap =new HashMap<String, Object>();
		String cname = request.getParameter("cname");
		parameterMap.put("cname", cname);
		//封装不完整的数据--cid
		String cid = CommonsUtil.getUUID();
		parameterMap.put("cid", cid);
		Category category =new Category();
		try {
			BeanUtils.populate(category, parameterMap);
		} catch (Exception e) {
			e.printStackTrace();
		}
		//封装完成，传递参数到service层
		AdminService service =new AdminService();
		service.addCategory(category);
		//重定向
		response.sendRedirect(request.getContextPath()+"/admin?methodName=findAllCategory");
	}
}