package cn.tzc.xianjian.day01;

import java.awt.Color;
import java.awt.Frame;
import java.awt.Graphics;
import java.awt.Panel;
import java.awt.Polygon;

public class Demo {
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
		MyPanel2 panel=new MyPanel2();
//6.�����ڶ�����Զ��廭�������й���
		ChuangKou.add(panel);
		ChuangKou.setBackground(new Color(255, 248, 220));
//3.�ô��ڳ��ֳ���
		ChuangKou.show(true);
	}
	
}
class MyPanel2 extends Panel{
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	public void drawTriangle(Graphics g,Color color,int x1,int y1,int x2,int y2,int x3,int y3,int x4,int y4) 
	{ 
		Polygon filledPolygon=new Polygon(); 
		filledPolygon.addPoint(x1,y1); 
		filledPolygon.addPoint(x2,y2); 
		filledPolygon.addPoint(x3,y3); 
		filledPolygon.addPoint(x4,y4); 
		g.setColor(color); 
		g.fillPolygon(filledPolygon); 
	}
	//�滭����
	public void paint(Graphics G) {
		//���Խ�g����һֻ����
//		g.drawLine(100, 100, 200, 200);//��ֱ��
//		g.drawRect(100, 100, 200, 200);//������
//		g.drawOval(100, 100, 200, 100);//��������Բ�����о��ε����Ͻ����꣬����
//		g.setColor(Color.RED);//�޸Ļ��ʵ���ɫ
//		g.fillRect(200, 200, 100, 100);//��ʵ�ľ���
//		g.fillOval(500, 500, 200, 200);//��ʵ����Բ
//		g.setColor(new Color(22, 22, 22));
//		g.fillOval(500, 500, 100, 100);
		G.setColor(new Color(22, 22, 22));//��ɫ
		G.fillOval(410, 140, 20, 20);
		G.fillOval(720, 140, 20, 20);
		G.fillRect(420, 148, 320, 5);
		G.fillRect(575, 150, 10, 300);//����
		//G.fillRect(525, 470, 10, 200);//����
		drawTriangle(G, new Color(1, 1, 1), 525, 470, 535, 670, 545, 670, 535, 470);//����
		//G.fillRect(615, 470, 10, 200);//����
		drawTriangle(G, new Color(1, 1, 1), 615, 470, 605, 670, 615, 670, 625, 470);//����
		G.fillRect(380, 280, 150, 10);//���
		G.fillRect(655, 300, 10, 100);//�ұ�
		G.setColor(new Color(107, 130, 35));//��ɫ
		G.fillOval(480, 260, 50, 50);//���
		G.fillOval(620, 260, 50, 50);//�Ҽ�
		
		G.setColor(new Color(255, 69, 0));//��ɫ
		G.fillRoundRect(360, 170, 10, 30, 10, 10);//��Ĵָ1
		G.fillRoundRect(640, 480, 10, 30, 10, 10);//��Ĵָ
		G.fillRoundRect(655, 480, 10, 30, 10, 10);
		G.fillRoundRect(670, 480, 10, 30, 10, 10);
		G.fillRoundRect(355, 190, 40, 100, 25, 25);//���ֱ���
		G.fillRoundRect(640, 390, 40, 100, 25, 25);//���ֱ���
//		G.fillRect(500, 250, 150, 150);//���ɣ���ɫ��
		G.fillRoundRect(500, 250, 150, 150, 20, 20);
//		G.fillRect(475, 100, 200, 100);//ͷ����ɫ��
		G.fillRoundRect(475, 100, 200, 100, 20, 20);
		G.fillOval(450, 125, 50, 50);//�������ɫ��
		G.fillOval(650, 125, 50, 50);//�Ҷ�����ɫ��
		G.fillRect(522, 450, 105, 25);//������֫����ɫ��
		G.fillOval(515, 450, 25, 25);
		G.fillOval(610, 450, 25, 25);//
		G.fillOval(485, 650, 70, 70);//���
		G.fillOval(590, 650, 70, 70);//�ҽ�
		G.setColor(new Color(255, 248, 220));//����ɫ
		G.fillRect(400, 680, 500, 100);//
		
		G.setColor(new Color(107, 142, 35));//��ɫ
		G.fillRect(520, 270, 110, 110);//�ؿ�
		G.fillRect(535, 450, 80, 25);//������֫����ɫ��
		G.fillOval(519, 545, 30, 30);
		G.fillOval(600, 545, 30, 30);
		
		G.setColor(new Color(122, 197, 205));//��ɫ
//		G.fillRect(485, 110, 180, 80);
		G.fillRoundRect(485, 110, 180, 80, 20, 20);
		
		G.setColor(new Color(22, 22, 22));//��ɫ
		G.fillOval(610, 290, 10, 10);
		G.fillOval(610, 320, 10, 10);
		G.fillOval(610, 350, 10, 10);
		G.fillOval(515, 125, 15, 15);
		G.fillOval(600, 125, 15, 15);
//		G.fillRect(555, 155, 40, 10);//���
		G.fillRoundRect(555, 160, 40, 10, 10, 10);
		G.fillRect(515, 125, 35, 5);
		G.fillRect(600, 125, 35, 5);
	}
	
}
