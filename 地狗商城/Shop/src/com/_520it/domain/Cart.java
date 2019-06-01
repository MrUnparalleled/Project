package com._520it.domain;

import java.util.HashMap;
import java.util.Map;

public class Cart {
	//商品中的n个购物项
	private Map<String, CartItem> cartItems =new HashMap<String, CartItem>();
	//购物车商品价值总计----初始化为0
	private double totalMoney = 0;
	public Map<String, CartItem> getCartItems() {
		return cartItems;
	}
	public void setCartItems(Map<String, CartItem> cartItems) {
		this.cartItems = cartItems;
	}
	public double getTotalMoney() {
		return totalMoney;
	}
	public void setTotalMoney(double totalMoney) {
		this.totalMoney = totalMoney;
	}
	
}
