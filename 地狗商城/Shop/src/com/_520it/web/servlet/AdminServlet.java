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
	 * ��̨��Ʒ��Ϣ�б�
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void productList(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//��������
		AdminService service =new AdminService();
		List<Product> productList = service.findAllProduct();
		//�����ݴ浽request����
		request.setAttribute("productList", productList);
		//System.out.println(productList);
		//����ת��
		request.getRequestDispatcher("/admin/product/list.jsp").forward(request, response);
	}
	
	/**
	 * ɾ����Ʒ
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void delProduct(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//��ȡ����
		String pid = request.getParameter("pid");
		AdminService service =new AdminService();
		service.delProduct(pid);
		//System.out.println(pid);
		response.sendRedirect(request.getContextPath()+"/admin?methodName=productList");
	}
	/**
	 * �������е���Ʒ���
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void findAllCategory(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//��������
		AdminService service =new AdminService();
		List<Category> categoryList = service.findAllCategory();
		request.setAttribute("categoryList", categoryList);
		request.getRequestDispatcher("/admin/category/list.jsp").forward(request, response);
		
		//System.out.println(categoryList.toString());
		/*
		 * //������ת����json
		Gson gson =new Gson();
		String json = gson.toJson(categoryList);
		//System.out.println(json);
		response.getWriter().write(json);
		 */
		
		
	}
	
	/**
	 * ��Ʒ��Ϣ���²�����׼������
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void productEditUI(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//���ղ���
		String pid = request.getParameter("pid");
		//��������Ͳ�����service��
		AdminService service =new AdminService();
		Product product = service.productEditUI(pid);
		//�����ݷŵ�request����
		request.setAttribute("product", product);
		//����ת��
		request.getRequestDispatcher("/admin/product/edit.jsp").forward(request, response);
	}
	
	
	/**
	 * ��������
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 */
	public void orderList(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//��������
		AdminService service =new AdminService();
		List<Order> orderList = service.orderList();
		request.setAttribute("orderList", orderList);
		request.getRequestDispatcher("/admin/order/list.jsp").forward(request, response);
	}

	/**
	 * ��������
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 * @throws InterruptedException 
	 */
	public void orderMessage(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException, InterruptedException {
		Thread.sleep(3000);
		//��ȡ����
		String oid = request.getParameter("oid");
		AdminService service =new AdminService();
		List<Map<String, Object>> orderItemList = service.orderMessage(oid);
		Gson gson =new Gson();
		String json = gson.toJson(orderItemList);
		response.getWriter().write(json);
	
	}
	
	/**
	 * ɾ����Ʒ���
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 * @throws InterruptedException
	 */
	public void delCategory(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException, InterruptedException {
		//��ò���--cid
		String cid = request.getParameter("cid");
		System.out.println(cid);
		AdminService service =new AdminService();
		service.delCategory(cid);
		request.getRequestDispatcher("/admin?method=findAllCategory").forward(request, response);
	}
	
	
	/**
	 * �����Ʒ���
	 * @param request
	 * @param response
	 * @throws ServletException
	 * @throws IOException
	 * @throws InterruptedException
	 */
	public void addCategory(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException, InterruptedException {
		//��ò���--cname
		Map<String, Object> parameterMap =new HashMap<String, Object>();
		String cname = request.getParameter("cname");
		parameterMap.put("cname", cname);
		//��װ������������--cid
		String cid = CommonsUtil.getUUID();
		parameterMap.put("cid", cid);
		Category category =new Category();
		try {
			BeanUtils.populate(category, parameterMap);
		} catch (Exception e) {
			e.printStackTrace();
		}
		//��װ��ɣ����ݲ�����service��
		AdminService service =new AdminService();
		service.addCategory(category);
		//�ض���
		response.sendRedirect(request.getContextPath()+"/admin?methodName=findAllCategory");
	}
}