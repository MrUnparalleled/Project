package cn.tzc.xianjian.day02;

import java.awt.Graphics;
import java.awt.Toolkit;

import javax.swing.ImageIcon;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;

public class MyGame {

	public static void main(String[] args) {
		//1.�滭��Ϸ����
		//1.1�����������ʵ��������
		JFrame frame=new JFrame();
		//1.3���ô��ڵ��������
		frame.setSize(1024, 768);
		frame.setTitle("�ҵĵ�һ����Ϸ");
		frame.setLocationRelativeTo(null);
		frame.setResizable(false);
		//�޸Ĵ��ڶ����Ĭ�Ϲرղ���ѡ��
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		//2.2�����Զ��廭�����ʵ��������
		MyGamePanel myPanel=new MyGamePanel();
		//2.3�����ڶ�����Զ��廭�����ʵ����������й���
		frame.add(myPanel);
		//1.2.�ô��ڶ�����ʾ����
		frame.setVisible(true);
		
	}

	}
	//2.�滭��Ϸ����
	//2.1 ��д�Զ��廭����
  class MyGamePanel extends JPanel{
	//�滭����
	public void paint(Graphics graphics) {
		//ǰ��׼������ͼƬ�ļ��ʹ����ļ������ͬһ������
//		graphics.drawImage(Toolkit.getDefaultToolkit().getImage(MyGamePanel.class.getResource("/Game_XianJian/src/cn/tzc/xianjian/day02/0.png")), -200, -200, this);
		//�滭7�����ͼƬ
		//��ǣ�������������ɩ�����죬С�����޼���С����СС��
//		ImageIcon bg=new ImageIcon("./Legend_of_Sword_and_Fairy/LiJiaCun/0.png");
//		JLabel label=new JLabel(bg);
//		label.setBounds(0,0, bg.getIconWidth(), bg.getIconHeight());
		graphics.drawImage(new ImageIcon("E:/java/workspace/Game_XianJian/Legend_of_Sword_and_Fairy/Legend_of_Sword_and_Fairy/LiJiaCun/0.png").getImage(),-200,-200,this);
		graphics.drawImage(new ImageIcon("E:/java/workspace/Game_XianJian/Legend_of_Sword_and_Fairy/Legend_of_Sword_and_Fairy/AWangShen/0.png").getImage(),450,310,this);
		graphics.drawImage(new ImageIcon("E:/java/workspace/Game_XianJian/Legend_of_Sword_and_Fairy/Legend_of_Sword_and_Fairy/MuJi/0.png").getImage(),530,100,this);
		graphics.drawImage(new ImageIcon("E:/java/workspace/Game_XianJian/Legend_of_Sword_and_Fairy/Legend_of_Sword_and_Fairy/WangCaiSao/0.png").getImage(),580,280,this);
		graphics.drawImage(new ImageIcon("E:/java/workspace/Game_XianJian/Legend_of_Sword_and_Fairy/Legend_of_Sword_and_Fairy/XiaoJi/0.png").getImage(),500,160,this);
		graphics.drawImage(new ImageIcon("E:/java/workspace/Game_XianJian/Legend_of_Sword_and_Fairy/Legend_of_Sword_and_Fairy/XiaoXiaoJi/0.png").getImage(),500,130,this);
}

}
