package com._520it.domain;

public class CartItem {
	//��������Ʒ
	private Product product;
	//���������Ʒ����
	private int buyNum;
	//�ù��������Ʒ��ֵ
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
