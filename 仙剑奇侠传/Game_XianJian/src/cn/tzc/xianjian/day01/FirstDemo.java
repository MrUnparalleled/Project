package cn.tzc.xianjian.day01;

import java.awt.Color;
import java.awt.Frame;
import java.awt.Graphics;
import java.awt.Panel;

/**
 * �����ļ�������ʾ�ҵĵ�һ�������ļ�
 * ���г���󣬻��ڵ�����Ļ�м����һ��1024*768��С����Ϸ����
 * @author �����
 *
 */

public class FirstDemo {
	//����������ʼִ�г����ʼִ�д�������
	@SuppressWarnings("deprecation")
	public static void main(String [] args) {
		/*
		 * ֪ʶ�㣺��Ͷ���
		 * �ࣺ�ǳ���ĸ���
		 * �����ǳ���ľ���ʵ����
		 * 
		 * ֪ʶ�㣺��ν����ɶ���
		 * �������ʵ������������ ������ = new ����������
		 */
//1.�����������ʵ��������
		Frame ChuangKou=new Frame();
//2.���ô��ڵ�������ݣ�����λ�ã�
		//���ô��ڵ�����
		ChuangKou.setSize(1024, 768);
		//�������λ�ã��ô��ڳ�������Ļ���룩
		ChuangKou.setLocationRelativeTo(null);
		//���ô��ڱ���
		ChuangKou.setTitle("�ҵĴ��ڳ���");
		ChuangKou.setResizable(false);
//5.�����Զ��廭�����ʵ��������
		MyPanel panel=new MyPanel();
//6.�����ڶ�����Զ��廭�������й���
		ChuangKou.add(panel);
		ChuangKou.setBackground(new Color(255, 248, 220));
//3.�ô��ڳ��ֳ���
		ChuangKou.show();
	}
}
//4.��д�Զ��廭����
class MyPanel extends Panel{
	//�滭����
	public void paint(Graphics g) {
		//���Խ�g����һֻ����
		g.drawLine(100, 100, 200, 200);//��ֱ��
		g.drawRect(100, 100, 200, 200);//������
		g.drawOval(100, 100, 200, 100);//��������Բ�����о��ε����Ͻ����꣬����
		g.setColor(Color.RED);//�޸Ļ��ʵ���ɫ
		g.fillRect(200, 200, 100, 100);//��ʵ�ľ���
		g.fillOval(500, 500, 200, 200);//��ʵ����Բ
		g.setColor(new Color(22, 22, 22));
		g.fillOval(500, 500, 100, 100);
	}
}
