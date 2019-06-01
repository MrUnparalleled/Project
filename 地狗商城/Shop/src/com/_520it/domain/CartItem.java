package com._520it.domain;

public class CartItem {
	//购物项商品
	private Product product;
	//购物项的商品数量
	private int buyNum;
	//该购物项的商品价值
	private double money;
	public Product getProduct() {
		return product;
	}
	public void setProduct(Product product) {
		this.product = product;
	}
	public int getBuyNum() {
		return buyNum;
	}
	public void setBuyNum(int buyNum) {
		this.buyNum = buyNum;
	}
	public double getMoney() {
		return money;
	}
	public void setMoney(double money) {
		this.money = money;
	}
	@Override
	public String toString() {
		return "CartItem [product=" + product + ", buyNum=" + buyNum + ", money=" + money + "]";
	}
	
	
}
