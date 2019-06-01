package com._520it.domain;

import java.util.List;

public class PageBean<T> {

	//总商品数
	private int totalProduct;
	//总页数
	private int totalPage;
	//当前页商品数
	private int currentProduct;
	//当前页数
	private int currentPage;
	//当前页商品
	private List<T> currentProductList;
	public int getCurrentProduct() {
		return currentProduct;
	}
	public void setCurrentProduct(int currentProduct) {
		this.currentProduct = currentProduct;
	}
	public int getTotalProduct() {
		return totalProduct;
	}
	public void setTotalProduct(int totalProduct) {
		this.totalProduct = totalProduct;
	}
	public int getCurrentPage() {
		return currentPage;
	}
	public void setCurrentPage(int currentPage) {
		this.currentPage = currentPage;
	}
	public int getTotalPage() {
		return totalPage;
	}
	public void setTotalPage(int totalPage) {
		this.totalPage = totalPage;
	}
	public List<T> getCurrentProductList() {
		return currentProductList;
	}
	public void setCurrentProductList(List<T> currentProductList) {
		this.currentProductList = currentProductList;
	}
	
}
