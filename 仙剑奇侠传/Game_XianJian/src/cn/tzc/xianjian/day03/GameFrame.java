package cn.tzc.xianjian.day03;

import java.awt.Cursor;
import java.awt.Point;
import java.awt.Toolkit;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.Statement;

import javax.swing.ImageIcon;
import javax.swing.JFrame;
import javax.swing.JOptionPane;

/**
 * ������Ϸ������ʾ��Ϸ��Ŀ�Ĵ���
 * @author �����
 *
 */
public class GameFrame {
	public static void main(String[] args) {
		String Message;
		//1.1�������ڣ����ô��ڱ���
		JFrame ChuangKou =new JFrame("�ɽ�������-�����-1.0");
		//���ô��ڴ�С���ɸ���
		ChuangKou.setResizable(false);
		//���ô��ڴ�С
		ChuangKou.setSize(1024, 768);
		//���ھ�����ʾ
		ChuangKou.setLocationRelativeTo(null);
		//���ô��ڵĹرշ�ʽ
		ChuangKou.setDefaultCloseOperation(JFrame.DO_NOTHING_ON_CLOSE);
		//�����ڹر�ʱ���赯��һ��ȷ�϶Ի���
		ChuangKou.addWindowListener(new WindowAdapter() {
//			@Override
//			public void windowOpened(WindowEvent e) {
//				// TODO Auto-generated method stub
//				super.windowOpened(e);
//				String xinxi=JOptionPane.showInputDialog(null,"��������Ϣ");
//				JOptionPane.showMessageDialog(null, xinxi);
//			}
			//���������ڱ��رյ�ʱ����Զ�����ִ�еķ���
			@Override
			public void windowClosing(WindowEvent e) {
				super.windowClosing(e);
				//����Ի���
//				String xinxi=JOptionPane.showInputDialog(null,"��������Ϣ");
//				//��Ϣ�Ի���
//				JOptionPane.showMessageDialog(null, xinxi);
				//ȷ�϶Ի���
				int jieguo=JOptionPane.showConfirmDialog(null, "ȷ��Ҫ�뿪�","ȷ�϶Ի���",JOptionPane.YES_NO_OPTION);
				if (jieguo==JOptionPane.YES_OPTION) {
					System.exit(0);
				}
			}
		});

		

		
		//2.2�����Զ��廭����ʵ��������
		GamePanel panel=new GamePanel();
		//���ñ�������
		// ��ʼ������
		MP3	ljcMusic = new MP3("E:/java/workspace/Game_XianJian/Music/BGM1.wav");
		ljcMusic.play();
		MP3	ddMusic = new MP3("E:/java/workspace/Game_XianJian/Music/fight1.wav");
		//2.3�����ڶ�����Զ��廭�������й���
		ChuangKou.add(panel);
		//�����߳����ʵ��������ͬʱ�����Զ��廭�����Ȼ�������̶߳���
		Thread xiancheng =new Thread(panel);
		xiancheng.start();
		//�ı������
		Cursor coursor = Toolkit.getDefaultToolkit().createCustomCursor(new ImageIcon("Image/mouse.png").getImage(),new Point(10,20), "stick");
		ChuangKou.setCursor(coursor);
		//
		ChuangKou.addKeyListener(panel);
		panel.addKeyListener(panel);

		//1.2ʹ�������ֳ���
		ChuangKou.setVisible(true);
	}
//	public void read() throws Exception {
//		String DB_URL="jdbc:mysql://localhost:3306/jdbcdemo"+"?serverTimezone=GMT%2B8";
//		String sql="CREATE TABLE t_student(id bigint(20) primary key auto_increment,name varchar(20));";
//		//����ע������
//		Class.forName("com.mysql.cj.jdbc.Driver");
//		
//		//��ȡ���Ӷ���
//		Connection conn=DriverManager.getConnection(DB_URL, "root", "root");
//		Statement state= conn.createStatement();
//		int i=state.executeUpdate(sql);
//		state.close();
//		conn.close();
//		
//		System.out.println(i);
//		
//		
//	}

}
