package com._520it.web.servlet;

import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.commons.beanutils.BeanUtils;
import org.apache.commons.fileupload.FileItem;
import org.apache.commons.fileupload.FileUploadException;
import org.apache.commons.fileupload.disk.DiskFileItemFactory;
import org.apache.commons.fileupload.servlet.ServletFileUpload;
import org.apache.commons.io.IOUtils;

import com._520it.domain.Product;
import com._520it.service.AdminService;
import com._520it.util.CommonsUtil;

public class AdminProductServlet extends HttpServlet {

	public void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// ������������
		// request.setCharacterEncoding("UTF-8");
		// response.setContentType("text/html;charset=utf-8");
		// ����һ��map���洢����
		Map<String, Object> productMap = new HashMap<String, Object>();
		// ����product
		Product product = new Product();
		String methodName = "";
		try {
			// 1.���������ļ��㳡
			DiskFileItemFactory factory = new DiskFileItemFactory();
			// 2.�����ļ��ϴ��ĺ�����
			ServletFileUpload upload = new ServletFileUpload(factory);
			upload.setHeaderEncoding("UTF-8");
			// �ж��Ƿ����ļ��ϴ���
			if (upload.isMultipartContent(request)) {
				// ���ļ��ϴ��ı�
				// 3.��������---����ļ����
				List<FileItem> parseRequest = upload.parseRequest(request);
				for (FileItem fileItem : parseRequest) {
					boolean formField = fileItem.isFormField();
					if (formField) {
						// ��ͨ��
						String fieldName = fileItem.getFieldName();
						String fieldValue = fileItem.getString("UTF-8");
						productMap.put(fieldName, fieldValue);
						if (fieldName.equals("methodName")) {
							methodName = fieldValue;
						}
					} else {
						// �ļ��ϴ���
						String path = this.getServletContext().getRealPath("/upload");
						String filename = fileItem.getName();
						InputStream inputStream = fileItem.getInputStream();
						OutputStream outputStream = new FileOutputStream(path + "/" + filename);
						IOUtils.copy(inputStream, outputStream);
						inputStream.close();
						outputStream.close();
						fileItem.delete();
						productMap.put("pimage", "upload/" + filename);
					}
				}
			}
			BeanUtils.populate(product, productMap);
		} catch (Exception e) {
			e.printStackTrace();
		}
		// �ֶ���װû�з�װ������

		// pdate
		SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd");
		String string = format.format(new Date());
		product.setPdate(string);
		// cid

		System.out.println(product.toString());
		// ���ò�ͬ�ķ�����dao��
		if (methodName != null) {
			if (methodName.equals("add")) {
				add(product);
			} else if (methodName.equals("edit")) {
				edit(product);
			}
		}

		response.sendRedirect(request.getContextPath() + "/admin?methodName=productList");
	}

	public void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		doGet(request, response);
	}

	public void add(Product product) throws ServletException, IOException {
		// pid
		product.setPid(CommonsUtil.getUUID());
		AdminService service = new AdminService();
		service.addProduct(product);
	}

	public void edit(Product product) throws ServletException, IOException {
		AdminService service = new AdminService();
		service.editProduct(product);
	}
}