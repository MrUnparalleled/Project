package com._520it.domain;

import java.util.HashMap;
import java.util.Map;

public class Cart {
	//��Ʒ�е�n��������
	private Map<String, CartItem> cartItems =new HashMap<String, CartItem>();
	//���ﳵ��Ʒ��ֵ�ܼ�----��ʼ��Ϊ0
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
