package cn.tzc.xianjian.day03;

import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.Image;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;
import javax.imageio.ImageIO;
import javax.swing.JPanel;

//ǰ��׼�������ز��ļ��и���ճ��������Ŀ¼��
//֪ʶ�㣺·��-->����·��+���·��
//����·�������̷���C:�����߸�Ŀ¼��/����ʼ��·��
//���·�����ڴ��������·���ӹ������ƺ��濪ʼ��д·��
/**
 * ������Ϸ������ʾ��Ϸ��Ŀ�Ļ���
 * 
 * @author �����
 *
 */
// �滭��Ϸ����
// 2.1��д�Զ��廭����
// ֪ʶ�㣺��Java�����У���ѭ���̳У��ࣩ��ʵ�֣��ӿڣ�
public class GamePanel extends JPanel implements Runnable, KeyListener {
	Image EndImage;
	//===================��Ʒ��===========================
	Image wpIcon;
	Image redAddIcon;
	Image blueAddIcon;
	Image redHurtIcon;
	Image blueHurtIcon;
	Image renwuIcon;
	Image fishIcon;
	//==================��Ʒ��ϵͳ=========================
	int Add_Red_Num;
	int Add_Red;
	int Add_blue;
	int Add_Blue_Num;
	int FishNum;
	//=================����ϵͳ===============================
	Image renwu;
	boolean isShow_RenWu;
	String[] renwuMessages;
	int renwuIndex;
	//===============��������ֵ================================
	int Red_yg;
	int Hurt_yg;
	int DefensivePower_yg;
	//=============����Ļ�������================================
	int Level;//�ȼ�
	int Red_lxy;//����Ѫ��
	int Blue_lxy;//���﷨��
	int NowYellow_lxy;//���ﵱǰ����
	int NeedYello_lxy;//�����������辭��
	int RedHurt_lxy;//�����˺�
	int BlueHurt_lxy;//�����˺�
	int BlueUse_lxy;//��������
	int DefensivePower_lxy;//������
	Image lxyMessageImage;
	Image FightEnd;
	Image Win;
	boolean canBlue;
	//==============================================
	//����ƬͷͼƬ
	Image dgImage;//����ͼƬ
	Image[] dg_lxygj_pgImages;//��ͨ��������ң��Ƭ
	int dg_gj_lxypgIndex;
	Image[] dg_lxygj_jnImages;//���ܹ�������ң
	int dg_gj_lxyjnIndex;
	Image[] dg_lxyBgjImages;//����������
	int dg_bgj_lxyIndex;
	Image[] dg_jnImages;//����������Ч
	Image[] dg_pgImages;//�չ���Ч
	int dg_pgIndex;
	Image[] dg_gj_gwImages;//��ֹ���
	int dg_gj_gwIndex;
	Image[] dg_bgj_gwImages;//��ֱ�����
	int dg_bgj_gwIndex;
	int dg_lxyX;
	int dg_lxyY;
	Image[] dg_zlImages;//���Ƽ���
	int dg_zlIndex;
	boolean isZL;
	boolean isPG;
	boolean isJN;
	boolean isDG_zl_lxy;
	boolean isDG_pg_lxy;
	boolean isMe;
	boolean isbgj_gw;
	boolean isgj_gw;
	boolean death_lxy;
	boolean death_yg;
	
	//=============================================
	// a.������Ҵ�ͼƬ���������
	BufferedImage ljcDateImage;// ������Ҵ��ϰ���ͼ
	Image ljcImage;// �����洢��Ҵ�ͼƬ������
	int ljcX;// ������ʾ��Ҵ�ͼƬ���Ͻǵ��X
	int ljcY;// ������ʾ��Ҵ�ͼƬ���Ͻǵ��Y
	// ���尢����ͼƬ���������
	Image[] awsImages;// �����洢����������µ�����ͼƬ������
	int awsX;
	int awsY;
	int awsIndex;
	// ����ĸ��ͼƬ���������
	Image[] mjImages;
	int mjX;
	int mjY;
	int mjIndex;
	// ��������ɩͼƬ���������
	Image[] wcsImages;
	int wcsX;
	int wcsY;
	int wcsIndex;
	// ����С��ͼƬ���������
	Image[] xjImages;
	int xjX;
	int xjY;
	int xjIndex;
	// ���尢��ͼƬ���������
	Image[] azImages;
	int azX;
	int azY;
	int azIndex;
	// ����СС��ͼƬ���������
	Image[] xxjImages;
	int xxjX;
	int xxjY;
	int xxjIndex;
	// ����С��ͼƬ���������
	Image[] xhImages;
	int xhX;
	int xhY;
	int xhIndex;
	// ��������ң����
	int lxyX;
	int lxyY;
	Image[] left_lxyImages;
	Image[] right_lxyImages;
	Image[] up_lxyImages;
	Image[] down_lxyImages;
	Image[] Up_Left_lxyImages;
	Image[] Up_Right_lxyImages;
	Image[] Down_Left_lxyImages;
	Image[] Down_Right_lxyImages;
	Image lxyImage;
	int lxyIndex;// ��������ң�������±�
	int lxyDir;// ��������ң�˶�����
	// ���尴��״̬
	boolean isLeft;
	boolean isRight;
	boolean isUp;
	boolean isDown;
	// ���������ƶ��ٶ�
	int Speed;
	int HighSpeed;
	// �����ٶ�״̬
	boolean isHighSpeed;
	// ���������Ч
	Image[] jsBuffImages;
	Image nulljsBuffImage;
	int jsBuffIndex;
	int jsBuffX;
	int jsBuffY;
	// ����ʹ�õ�ѭ����������
	MP3 Music;
	// �����ͼ
	int MapId;
	// ��������ң������λ��
	int x;
	int y;
	Image[] TitleImages;
	int xTitle;
	int yTitle;
	int TitleIndex;
	boolean isTitle;
	// ���������������
	Image ltImage;
	int ltImageX;
	int ltImageY;
	String ltMessage;
	int ltIndex;
	// ����ɩ��
	String lt_0_wcsMessage;
	String[] lt_1_wcsMessages;
	String[] lt_2_wcsMessages;
	String[] lt_3_wcsMessages;
	// ���컰
	String lt_0_azMessage;
	String lt_2_azMessage;
	String[] lt_1_azMessages;
	// ������
	String[] lt_1_1awsMessages;
	String[] lt_1_0awsMessages;
	String[] lt_2_0awsMessages;
	String[] lt_2_1awsMessages;
	String[] lt_3_1awsMessages;
	String[] lt_3_2awsMessages;
	// С��
	String[] lt_2_xhMessages;
	String[] lt_1_xhMessages;
	String lt_0_xhMessage;
	// ����ң
	String[] lt_0_lxyMessages;
	String faceman;
	int Dir1;// ������ֱ����
	int Dir2;// ����ˮƽ����
	int lxyNow;
	boolean IsLtShow;

	// ���췽��
	public GamePanel() {
		// �������鳤��
		xhImages = new Image[4];
		xjImages = new Image[2];
		xxjImages = new Image[2];
		azImages = new Image[6];
		awsImages = new Image[17];
		mjImages = new Image[6];
		wcsImages = new Image[14];
		left_lxyImages = new Image[4];
		right_lxyImages = new Image[4];
		up_lxyImages = new Image[4];
		down_lxyImages = new Image[4];
		Up_Left_lxyImages = new Image[4];
		Up_Right_lxyImages = new Image[4];
		Down_Left_lxyImages = new Image[4];
		Down_Right_lxyImages = new Image[4];
		jsBuffImages = new Image[16];
		TitleImages = new Image[9];
		//====================
		dg_lxygj_jnImages=new Image[3];
		dg_lxygj_pgImages=new Image[4];
		dg_lxyBgjImages=new Image[3];
		dg_zlImages=new Image[8];
		dg_pgImages=new Image[5];
		dg_bgj_gwImages=new Image[5];
		dg_gj_gwImages=new Image[6];
		// b.��ʼ����Ҵ峡����ͼƬ�������
		try {
			//==========��ʼ��������======
			wpIcon=ImageIO.read(new File("Image/jinengkuang.png"));
			blueAddIcon=ImageIO.read(new File("Image/blue.jpg"));
			blueHurtIcon=ImageIO.read(new File("Image/blueHurt.png"));
			redAddIcon=ImageIO.read(new File("Image/red.jpg"));
			redHurtIcon=ImageIO.read(new File("Image/redHurt.png"));
			fishIcon=ImageIO.read(new File("Image/fish.jpg"));
			renwuIcon=ImageIO.read(new File("Image/renwu.jpg"));
			//=========��ʼ���򶷳���==============
			Win=ImageIO.read(new File("DaGuai/Win.png"));
			FightEnd=ImageIO.read(new File("DaGuai/End.png"));
			dgImage=ImageIO.read(new File("DaGuai/dg_background.png"));
			for (int i = 0; i < dg_lxygj_jnImages.length; i++) {
				dg_lxygj_jnImages[i]=ImageIO.read(new File("DaGuai/DaDou/gj_jn/"+i+".png"));
			}
			for (int i = 0; i < dg_lxygj_pgImages.length; i++) {
				dg_lxygj_pgImages[i]=ImageIO.read(new File("DaGuai/DaDou/gj_pg/"+i+".png"));
			}
			for (int i = 0; i < dg_lxyBgjImages.length; i++) {
				dg_lxyBgjImages[i]=ImageIO.read(new File("DaGuai/DaDou/bgj/"+i+".png"));
			}
			for (int i = 0; i < dg_zlImages.length; i++) {
				dg_zlImages[i]=ImageIO.read(new File("DaGuai/JiNen/ZhiLiao/"+i+".png"));
			}
			for (int i = 0; i < dg_pgImages.length; i++) {
				dg_pgImages[i]=ImageIO.read(new File("DaGuai/JiNen/PuGong/"+i+".png"));
			}
			for (int i = 0; i < dg_gj_gwImages.length; i++) {
				dg_gj_gwImages[i]=ImageIO.read(new File("DaGuai/YuGuai/gj/"+i+".png"));
			}
			for (int i = 0; i < dg_bgj_gwImages.length; i++) {
				dg_bgj_gwImages[i]=ImageIO.read(new File("DaGuai/YuGuai/bgj/"+i+".png"));
			}
			//===========��ʼ����Ҵ�================
			EndImage=ImageIO.read(new File("Image/end.png"));
			renwu=ImageIO.read(new File("Image/juanzhou.png"));
			lxyMessageImage=ImageIO.read(new File("Legend_of_Sword_and_Fairy/RenWu/ztl.png"));
			//��ʼ����Ҵ��ϰ���ͼ
			ljcDateImage = ImageIO.read(new File("Legend_of_Sword_and_Fairy/LiJiaCun/RedMap.png"));
			// ��ʼ����Ҵ�
			ljcImage = ImageIO.read(new File("Legend_of_Sword_and_Fairy/LiJiaCun/0.png"));
			// ��ʼ��������
			for (int i = 0; i < awsImages.length; i++) {
				awsImages[i] = ImageIO.read(new File("Legend_of_Sword_and_Fairy/AWangShen/" + i + ".png"));
			}
			// ��ʼ��ĸ��
			for (int i = 0; i < mjImages.length; i++) {
				mjImages[i] = ImageIO.read(new File("Legend_of_Sword_and_Fairy/MuJi/" + i + ".png"));
			}
			// ��ʼ������ɩ
			for (int i = 0; i < wcsImages.length; i++) {
				wcsImages[i] = ImageIO.read(new File("Legend_of_Sword_and_Fairy/WangCaiSao/" + i + ".png"));
			}
			// ��ʼ��С��
			for (int i = 0; i < xjImages.length; i++) {
				xjImages[i] = ImageIO.read(new File("Legend_of_Sword_and_Fairy/XiaoJi/" + i + ".png"));
			}
			// ��ʼ��СС��ͼƬ
			for (int i = 0; i < xxjImages.length; i++) {
				xxjImages[i] = ImageIO.read(new File("Legend_of_Sword_and_Fairy/XiaoXiaoJi/" + i + ".png"));
			}
			// ��ʼ������ͼƬ
			for (int i = 0; i < azImages.length; i++) {
				azImages[i] = ImageIO.read(new File("Legend_of_Sword_and_Fairy/AZhu/" + i + ".png"));
			}
			// ��ʼ��С��ͼƬ
			for (int i = 0; i < xhImages.length; i++) {
				xhImages[i] = ImageIO.read(new File("Legend_of_Sword_and_Fairy/XiaoHai/" + i + ".png"));
			}
			// ��ʼ������ң�Ķ���ͼƬ
			for (int i = 0; i < left_lxyImages.length; i++) {
				left_lxyImages[i] = ImageIO.read(new File("LiXiaoYao/left/" + i + ".png"));
			}
			for (int i = 0; i < right_lxyImages.length; i++) {
				right_lxyImages[i] = ImageIO.read(new File("LiXiaoYao/right/" + i + ".png"));
			}
			for (int i = 0; i < up_lxyImages.length; i++) {
				up_lxyImages[i] = ImageIO.read(new File("LiXiaoYao/up/" + i + ".png"));
			}
			for (int i = 0; i < down_lxyImages.length; i++) {
				down_lxyImages[i] = ImageIO.read(new File("LiXiaoYao/down/" + i + ".png"));
			}
			for (int i = 0; i < Up_Left_lxyImages.length; i++) {
				Up_Left_lxyImages[i] = ImageIO.read(new File("LiXiaoYao/up_left/" + i + ".png"));
			}
			for (int i = 0; i < Down_Left_lxyImages.length; i++) {
				Down_Left_lxyImages[i] = ImageIO.read(new File("LiXiaoYao/down_left/" + i + ".png"));
			}
			for (int i = 0; i < Down_Right_lxyImages.length; i++) {
				Down_Right_lxyImages[i] = ImageIO.read(new File("LiXiaoYao/down_right/" + i + ".png"));
			}
			for (int i = 0; i < Up_Right_lxyImages.length; i++) {
				Up_Right_lxyImages[i] = ImageIO.read(new File("LiXiaoYao/up_right/" + i + ".png"));
			}
			// ��ʼ������
			for (int i = 0; i < jsBuffImages.length; i++) {
				jsBuffImages[i] = ImageIO.read(new File("buff/" + i + ".png"));
			}
			nulljsBuffImage = ImageIO.read(new File("buff/16.png"));
			// ��ʼ������ƺ�
			for (int i = 0; i < TitleImages.length; i++) {
				TitleImages[i] = ImageIO.read(new File("title2/" + i + ".png"));
			}
			ltImage = ImageIO.read(new File("Legend_of_Sword_and_Fairy/LiaoTian/0.png"));
		} catch (IOException e) {
			e.printStackTrace();
		}
		ljcX = -200;
		ljcY = -200;
		// ��ʼ��������ͼƬ���������
		awsX = 650;
		awsY = 510;
		awsIndex = 0;
		// ��ʼ��ĸ��ͼƬ���������
		mjX = 740;
		mjY = 340;
		mjIndex = 0;
		// ��ʼ������ɩͼƬ���������
		wcsX = 780;
		wcsY = 480;
		wcsIndex = 0;
		// ��ʼ��С��ͼƬ���������
		xjX = 710;
		xjY = 370;
		xjIndex = 0;
		// ��ʼ��СС��ͼƬ���������
		xxjX = 710;
		xxjY = 340;
		xxjIndex = 0;
		// ��ʼ������ͼƬ���������
		azX = 730;
		azY = 250;
		azIndex = 0;
		// ��ʼ��С��ͼƬ���������
		xhX = 1090;
		xhY = 770;
		xhIndex = 0;
		// ��ʼ������ң���������
		lxyX = 400;
		lxyY = 400;
		lxyIndex = 0;
		lxyImage = down_lxyImages[lxyIndex];
		// ��ʼ������״ֵ̬
		isRight = false;
		isLeft = false;
		isUp = false;
		isDown = false;
		// ��ʼ������ң�ƶ��ٶ�
		Speed = 10;
		HighSpeed = 20;
		isHighSpeed = false;
		// ��ʼ������Buff
		jsBuffIndex = 0;
		jsBuffX = -5;
		jsBuffY = 70;
		
		// ��ʼ����ͼ
		MapId = 1;
		// ��ʼ������ƺ�
		xTitle = -70;
		yTitle = -64;
		TitleIndex = 0;
		isTitle = false;
		//==================��ʼ������ϵͳ================
		renwuMessages=new String[] {"�Ұ�����̸��","������ɩ̸��","��С��̸��","�Ұ���̸��","������ɩ̸��","�Ұ�����̸��","���븱�������","�Ұ�����̸��"};
		renwuIndex=0;
		// ��ʼ�����칦�ܵ��������
		lt_0_azMessage = new String("С��.С��.�쳤��");
		lt_0_wcsMessage = new String("ϴˢˢ.ϴˢˢ");
		lt_0_xhMessage = new String("��Ҫһ������");
		lt_2_azMessage = new String("�����Ѿ�ȥ���˰�");
		lt_0_lxyMessages = new String[] { "������ô��,����ȥ����", "����ȥ��������˵һ��" };
		lt_1_azMessages = new String[] { "����ң������~", "���죺��ң����ʲô��", "����ң�����ܲ��ܰ���ȥ��������ؼ�", "���죺�����Ķ���", "����ң���ڴ嶫������",
				"һ��Ҫ��ȥ�ſϻؼ�", "���죺�õģ������ȥ" };
		lt_1_1awsMessages = new String[] { "����ң���㺿��������", "��������Ӵ������ң������", "����ң���Ҹ���˵��...", "�������������ȥ����ɩ�Ǳ��ü����·���",
				"����ң���Ǹ�...", "�����������", "����ң��Ŷ" };
		lt_2_1awsMessages = new String[] { "����ң��������Ҫ���·�", "��������Ŷ", "����ң������ȥ��������翴��", "������տ�һ�¼���",
				"�����������㣿����ȥɱ�����������" };
		lt_2_0awsMessages = new String[] { "����������ô�ˣ�����", "����ң���Ǻǣ�����" };
		lt_3_1awsMessages = new String[] { "����ң�������Ұ����ɱ��", "��������Ӵ�����а�", "����ң�����ҳ�ȥ����������", "����������Ҫ��ȥ���Ҳ�������",
				"�������ǧ��С��" };
		lt_1_0awsMessages = new String[] { "������������ô�����ˣ�����", "����ң����������.." };
		lt_1_wcsMessages = new String[] { "����ң������ɩ~~~", "����ɩ:ȥ���Ҽ������һ���", "����ң���Ǹ�...", "����ɩ�����ͱ���ȥ����ȥ��", "����ң��Ŷ~",
				"����ң���Ͳ������Ұѻ�˵����(һ������~~)" };
		lt_3_wcsMessages = new String[] { "����ң��������ƻ����˰�", "����ɩ��Ŷ�������ˣ����߰�", "����ң����������", "��һ�£��������ǰ�����Ҫ�ü����·�",
				"����ɩ��������£����㲻��˵", "����ң��..." };
		lt_2_wcsMessages = new String[] { "����ɩ����ȥ��ȥ", "����ң����������" };
		lt_1_xhMessages = new String[] { "����ң��ι��Сƨ����������", "���ƣ���ƨ���", "����ң��...(��ô�񣿣�)", "��������ؼҳԷ��أ���", "���ƣ���ȥ������...",
				"�����Ұ����������һ�ȥ", "����ң��������ȥ", "���ƣ����Ҿͺ�����˵���۸���", "����ң��..." };
		lt_2_xhMessages = new String[] { "���ƣ��٣�����ô������", "����ң��������" };
		ltMessage = "hello";
		faceman = "";
		Dir1 = KeyEvent.VK_DOWN;
		Dir2 = KeyEvent.VK_SPACE;
		lxyNow = 1;
		IsLtShow = false;
		ltIndex = 0;
		isShow_RenWu=false;
		
		//==================
		dg_lxyX=800;
		dg_lxyY=400;
		dg_gj_lxyjnIndex=0;
		dg_bgj_lxyIndex=0;
		dg_gj_lxypgIndex=0;
		dg_gj_gwIndex=0;
		dg_bgj_gwIndex=0;
		isJN=false;
		isZL=false;
		isPG=false;
		isDG_pg_lxy=false;
		isDG_zl_lxy=false;
		isMe=true;
		isbgj_gw=false;
		isgj_gw=false;
		death_lxy=false;
		death_yg=false;
		//=======��ʼ����������==========
		Level=1;
		Red_lxy=100;
		Blue_lxy=200;
		NowYellow_lxy=0;
		NeedYello_lxy=50;
		RedHurt_lxy=20;
		BlueHurt_lxy=50;
		BlueUse_lxy=30;
		DefensivePower_lxy=15;
		canBlue=true;
		//==========��ʼ����������=========
		Red_yg=100;
		Hurt_yg=20;
		DefensivePower_yg=10;
		//=============��Ʒ��=================
		FishNum=0;
		Add_Red=50;
		Add_Red_Num=5;
		Add_blue=50;
		Add_Blue_Num=5;
	}

	// �滭����
	public void paint(Graphics graphics) {
		if (MapId==0) {
			graphics.drawImage(dgImage, 0, 0, this);
			if (death_lxy==true ||death_yg==true) {
				if (death_lxy==true) {
					graphics.drawImage(FightEnd, 0, 0, this);
				}
				if (death_yg==true) {
					graphics.drawImage(Win, 600, 400, this);
				}
			}
			else {
			if (isMe==false) {
				graphics.drawImage(dg_gj_gwImages[dg_gj_gwIndex], 200, 300, this);
				graphics.drawImage(dg_lxyBgjImages[dg_bgj_lxyIndex], dg_lxyX, dg_lxyY, this);
			}
			if (isMe==true) {
				if (isDG_zl_lxy==false&& isDG_pg_lxy==false) {
					graphics.drawImage(dg_lxygj_jnImages[0], dg_lxyX, dg_lxyY, this);
					graphics.drawImage(dg_bgj_gwImages[0], 200, 300, this);
				}
				if (isZL==true && canBlue==true) {
					graphics.drawImage(dg_zlImages[dg_zlIndex], 120, 80, this);
				}
				if (isDG_pg_lxy==true) {
					graphics.drawImage(dg_lxygj_pgImages[dg_gj_lxypgIndex], dg_lxyX, dg_lxyY, this);
					graphics.drawImage(dg_bgj_gwImages[dg_bgj_gwIndex], 200, 300, this);
				}
				if (isDG_zl_lxy==true && canBlue==true) {
					graphics.drawImage(dg_lxygj_jnImages[dg_gj_lxyjnIndex], dg_lxyX, dg_lxyY, this);
					graphics.drawImage(dg_bgj_gwImages[dg_bgj_gwIndex], 200, 300, this);
				}
				if (isPG==true) {
					graphics.drawImage(dg_pgImages[dg_pgIndex], 100, 150, this);
				}
			}
			//����������ʾ
			graphics.drawImage(lxyMessageImage, 600, -30, this);
			graphics.setColor(Color.WHITE);
			graphics.setFont(new Font("΢���ź�", Font.BOLD, 15));
			graphics.drawString(" "+Red_lxy, 830, 34);
			graphics.drawString(" "+NowYellow_lxy, 950, 34);
			graphics.drawString(" "+BlueHurt_lxy, 930, 58);
			graphics.drawString(" "+RedHurt_lxy, 830, 58);
			graphics.drawString(" "+DefensivePower_lxy, 830, 82);
			graphics.drawString(" "+Blue_lxy, 930, 82);
			graphics.drawString(" "+Level, 665, 110);
			//���������ʾ
			graphics.drawImage(lxyMessageImage, -30, -30, this);
			graphics.setColor(Color.WHITE);
			graphics.setFont(new Font("΢���ź�", Font.BOLD, 15));
			graphics.drawString(" "+Red_yg, 200, 34);
			graphics.drawString(" "+Hurt_yg, 200, 58);
			graphics.drawString(" "+DefensivePower_yg, 200, 82);
			graphics.drawString(" 1", 35, 110);
			}
		}
		// c.�滭��Ҵ�ͼƬ���������
		if (MapId == 1) {
			if (NowYellow_lxy>=NeedYello_lxy) {
				Level+=1;
				NeedYello_lxy=2*NeedYello_lxy;
			}
			graphics.drawImage(ljcImage, ljcX, ljcY, this);
			graphics.drawImage(awsImages[awsIndex], awsX + ljcX, awsY + ljcY, this);
			graphics.drawImage(mjImages[mjIndex], mjX + ljcX, mjY + ljcY, this);
			graphics.drawImage(wcsImages[wcsIndex], wcsX + ljcX, wcsY + ljcY, this);
			graphics.drawImage(xjImages[xjIndex], xjX + ljcX, xjY + ljcY, this);
			graphics.drawImage(xxjImages[xxjIndex], xxjX + ljcX, xxjY + ljcY, this);
			if (lxyNow<=4) {
				graphics.drawImage(azImages[azIndex], azX + ljcX, azY + ljcY, this);
				graphics.drawImage(xhImages[xhIndex], xhX + ljcX, xhY + ljcY, this);
			}
			graphics.drawImage(lxyImage, lxyX, lxyY, this);
			// ���Ƽ���buff
			if (isHighSpeed == true) {
				graphics.drawImage(jsBuffImages[jsBuffIndex], jsBuffX + lxyX, jsBuffY + lxyY, this);
			}
			// �滭����ƺ�
			if (isTitle == true) {
				graphics.drawImage(TitleImages[TitleIndex], xTitle + lxyX, lxyY + yTitle, this);
			}
			if (IsLtShow == true) {
				ltImageX = (this.getWidth() - ltImage.getWidth(null)) / 2;
				ltImageY = this.getHeight() - ltImage.getHeight(null);
				graphics.drawImage(ltImage, ltImageX, ltImageY, this);
				graphics.setColor(Color.RED);
				graphics.setFont(new Font("΢���ź�", Font.BOLD, 20));
				if (lxyNow == 1) {
					if (faceman == "aws") {
						graphics.drawString(lt_1_1awsMessages[ltIndex], ltImageX + 30, ltImageY + 50);
					}
					if (faceman == "az") {
						graphics.drawString(lt_0_azMessage, ltImageX + 30, ltImageY + 50);
					}
					if (faceman == "wcs") {
						graphics.drawString(lt_0_wcsMessage, ltImageX + 30, ltImageY + 50);
					}
					if (faceman == "xh") {
						graphics.drawString(lt_0_xhMessage, ltImageX + 30, ltImageY + 50);
					}
				}
				if (lxyNow==2) {
					if (faceman == "aws") {
						graphics.drawString(lt_1_0awsMessages[ltIndex], ltImageX + 30, ltImageY + 50);
					}
					if (faceman == "az") {
						graphics.drawString(lt_0_azMessage, ltImageX + 30, ltImageY + 50);
					}
					if (faceman == "wcs") {
						graphics.drawString(lt_1_wcsMessages[ltIndex], ltImageX + 30, ltImageY + 50);
					}
					if (faceman == "xh") {
						graphics.drawString(lt_0_xhMessage, ltImageX + 30, ltImageY + 50);
					}
				}
				if (lxyNow==3) {
					if (faceman == "aws") {
						graphics.drawString(lt_1_0awsMessages[ltIndex], ltImageX + 30, ltImageY + 50);
					}
					if (faceman == "az") {
						graphics.drawString(lt_0_azMessage, ltImageX + 30, ltImageY + 50);
					}
					if (faceman == "wcs") {
						graphics.drawString(lt_2_wcsMessages[ltIndex], ltImageX + 30, ltImageY + 50);
					}
					if (faceman == "xh") {
						graphics.drawString(lt_1_xhMessages[ltIndex], ltImageX + 30, ltImageY + 50);
					}
				}
				if (lxyNow==4) {
					if (faceman == "aws") {
						graphics.drawString(lt_1_0awsMessages[ltIndex], ltImageX + 30, ltImageY + 50);
					}
					if (faceman == "az") {
						graphics.drawString(lt_1_azMessages[ltIndex], ltImageX + 30, ltImageY + 50);
					}
					if (faceman == "wcs") {
						graphics.drawString(lt_2_wcsMessages[ltIndex], ltImageX + 30, ltImageY + 50);
					}
					if (faceman == "xh") {
						graphics.drawString(lt_0_xhMessage, ltImageX + 30, ltImageY + 50);
					}
				}
				if (lxyNow==5) {
					if (faceman=="aws") {
						graphics.drawString(lt_1_0awsMessages[ltIndex], ltImageX + 30, ltImageY + 50);
					}
					if (faceman=="wcs") {
						graphics.drawString(lt_3_wcsMessages[ltIndex], ltImageX + 30, ltImageY + 50);
					}
					if (faceman=="az") {
						graphics.drawString(lt_2_azMessage, ltImageX + 30, ltImageY + 50);
					}
				}
				if (lxyNow==6) {
					if (faceman=="aws") {
						graphics.drawString(lt_2_1awsMessages[ltIndex], ltImageX + 30, ltImageY + 50);
					}
					if (faceman=="wcs") {
						graphics.drawString(lt_0_wcsMessage, ltImageX + 30, ltImageY + 50);
					}
				}
				if (lxyNow==7) {
					if (faceman=="aws") {
						graphics.drawString(lt_2_0awsMessages[ltIndex], ltImageX + 30, ltImageY + 50);
					}
					if (faceman=="wcs") {
						graphics.drawString(lt_0_wcsMessage, ltImageX + 30, ltImageY + 50);
					}
				}
				if (lxyNow==8) {
					if (faceman=="aws") {
						graphics.drawString(lt_3_1awsMessages[ltIndex], ltImageX + 30, ltImageY + 50);
					}
					if (faceman=="wcs") {
						graphics.drawString(lt_0_wcsMessage, ltImageX + 30, ltImageY + 50);
					}
				}
				
			}
			if (isShow_RenWu==true) {
				graphics.drawImage(renwu, -100, -200, this);
				graphics.setFont(new Font("����", Font.BOLD, 25));
				graphics.drawString(renwuMessages[lxyNow-1], 770, 450);
			}
			//========�滭��Ʒ��============
			graphics.drawImage(wpIcon, 965, 200, this);
			graphics.drawImage(wpIcon, 965, 350, this);
			graphics.drawImage(redHurtIcon, 974, 244, this);
			graphics.drawImage(blueHurtIcon, 974, 207, this);
			graphics.drawImage(redAddIcon, 974, 280, this);
			graphics.drawImage(blueAddIcon, 974, 316, this);
			graphics.drawImage(renwuIcon, 974, 357, this);
			graphics.drawImage(fishIcon, 974, 393, this);
			//========================================
			graphics.drawImage(lxyMessageImage, -30, -30, this);
			graphics.setColor(Color.WHITE);
			graphics.setFont(new Font("΢���ź�", Font.BOLD, 15));
			graphics.drawString(" "+Red_lxy, 200, 34);
			graphics.drawString(" "+NowYellow_lxy+"/"+NeedYello_lxy, 310, 34);
			graphics.drawString(" "+BlueHurt_lxy, 300, 58);
			graphics.drawString(" "+RedHurt_lxy, 200, 58);
			graphics.drawString(" "+DefensivePower_lxy, 200, 82);
			graphics.drawString(" "+Blue_lxy, 300, 82);
			graphics.drawString(" "+Level, 35, 110);
			if (lxyNow==9) {
				graphics.drawImage(EndImage, 0, 0, this);
				lxyNow++;
			}
		}
	}
	
	// �˶�����
	public void run() {
		// ʵ����ǵ��˶�Ч��
		// ��������˵��Ҳ���ǲ��ϵ��޸�ͼƬ����ĵ�ǰ�±�
		while (true) {
			peopleRun();
			Fighting();

			try {
				Thread.sleep(130);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
			// ���»滭ͼƬ
			repaint();
		}
	}
	//��̬Ч��ʵ��
	private void peopleRun() {
		awsIndex++;
		if (awsIndex >= awsImages.length) {
			awsIndex = 0;
		}
		mjIndex++;
		if (mjIndex >= mjImages.length) {
			mjIndex = 0;
		}
		wcsIndex++;
		if (wcsIndex >= wcsImages.length) {
			wcsIndex = 0;
		}
		xjIndex++;
		if (xjIndex >= xjImages.length) {
			xjIndex = 0;
		}
		xxjIndex++;
		if (xxjIndex >= xxjImages.length) {
			xxjIndex = 0;
		}
		azIndex++;
		if (azIndex >= azImages.length) {
			azIndex = 0;
		}
		xhIndex++;
		if (xhIndex >= xhImages.length) {
			xhIndex = 0;
		}
		jsBuffIndex++;
		if (jsBuffIndex >= jsBuffImages.length) {
			jsBuffIndex = 0;
		}
		TitleIndex++;
		if (TitleIndex >= TitleImages.length) {
			TitleIndex = 0;
		}
	}
	//��ֳ����߼�ʵ��
	private void Fighting() {
		if (Red_yg<=0 || Red_lxy<=0) {
			if (Red_lxy<=0) {
				death_lxy=true;
			}
			if (Red_yg<=0) {
				death_yg=true;
			}
			
		}else {
			//�����
			if (isMe==false) {
				dg_gj_gwIndex++;
				if (dg_gj_gwIndex >= dg_gj_gwImages.length) {
					dg_gj_gwIndex = 0;
					Red_lxy=Red_lxy-Hurt_yg+DefensivePower_lxy;
					isMe=true;
				}
				dg_bgj_lxyIndex++;
				if (dg_bgj_lxyIndex >= dg_lxyBgjImages.length) {
					dg_bgj_lxyIndex = 0;
				}
			}
			//�����
			if (isMe==true) {

					if (isDG_pg_lxy==true) {
						dg_gj_lxypgIndex++;
						if (dg_gj_lxypgIndex >= dg_lxygj_pgImages.length) {
							dg_gj_lxypgIndex = 0;
							isDG_pg_lxy=false;
						}
						dg_bgj_gwIndex++;
						if (dg_bgj_gwIndex >= dg_bgj_gwImages.length) {
							dg_bgj_gwIndex = 0;
						}
					}
					else if (isDG_zl_lxy==true) {
							dg_gj_lxyjnIndex++;
							if (dg_gj_lxyjnIndex >= dg_lxygj_jnImages.length) {
								dg_gj_lxyjnIndex = 0;
								isDG_zl_lxy=false;
							}
							dg_bgj_gwIndex++;
							if (dg_bgj_gwIndex >= dg_bgj_gwImages.length) {
								dg_bgj_gwIndex = 0;
							}
					}
					if (isZL==true) {
							dg_zlIndex++;
							isPG=false;
							if (dg_zlIndex >= dg_zlImages.length) {
								dg_zlIndex = 0;
								isZL=false;
								Blue_lxy-=BlueUse_lxy;
								Red_yg=Red_yg-BlueHurt_lxy+DefensivePower_yg;
								isMe=false;
							}
							dg_bgj_gwIndex++;
							if (dg_bgj_gwIndex >= dg_bgj_gwImages.length) {
								dg_bgj_gwIndex = 0;
							}
							canBlue=true;
						}
					}
					if (isPG==true) {
						dg_pgIndex++;
						isZL=false;
						if (dg_pgIndex >= dg_pgImages.length) {
							dg_pgIndex = 0;
							isPG=false;
							Red_yg=Red_yg-RedHurt_lxy+DefensivePower_yg;
							isMe=false;
						}
						dg_bgj_gwIndex++;
						if (dg_bgj_gwIndex >= dg_bgj_gwImages.length) {
							dg_bgj_gwIndex = 0;
						}
					}
				}
		
	}

	@Override
	public void keyPressed(KeyEvent e) {
		// ��=38����=40����=37����=39��w=87,s=83,a=65,d=68���ո�=32��
		// ���Խ�e�����¼�Դ
		// ʵ�����ǵ��˶�Ч��
		// ������Ұ��µļ����ϰ�����������ж�Ӧ�������ƶ���ԭ�ز�����

		// �洢����ֵ
		int KeyCode = e.getKeyCode();
		if (MapId==0) {
			if (KeyCode==KeyEvent.VK_Q) {
				if (isMe==true) {
					isPG=true;
					isDG_pg_lxy=true;
					
				}
			}
			if (KeyCode==KeyEvent.VK_W) {
				if (isMe==true) {
					isJN=true;
				}
			}
			if (KeyCode==KeyEvent.VK_E) {
				if (isMe==true) {
					if (Blue_lxy>BlueUse_lxy) {
						isZL=true;
						isDG_zl_lxy=true;
					}else {
						isZL=false;
						isDG_zl_lxy=false;
					}
				}
		}
			if (death_yg==true) {
				if (KeyCode==KeyEvent.VK_SPACE) {
					FishNum+=1;
					MapId=1;
					NowYellow_lxy+=60;
				}
			}
			if (death_lxy==true) {
				if (KeyCode==KeyEvent.VK_SPACE) {
					MapId=1;
				}
			}
		}
		else if (MapId==1) {
			if (KeyCode==KeyEvent.VK_L) {
				isShow_RenWu=!isShow_RenWu;
			}
			if (KeyCode==KeyEvent.VK_1) {
				if (Add_Red_Num>0) {
					Add_Red_Num-=1;
					Red_lxy+=Add_Red;
				}
			}
			if (KeyCode==KeyEvent.VK_2) {
				if (Add_Blue_Num>0) {
					Add_Blue_Num-=1;
					Blue_lxy+=Add_blue;
				}
			}
			if (IsLtShow == true) {
				if (KeyCode == KeyEvent.VK_SPACE) {
					ltIndex++;
					if (lxyNow==10) {
						//============���ص�Ƭͷ=====Ƭͷ���г�ʼ��===========
						//MapId=1;
					}
					if (lxyNow == 1) {
						if (faceman == "aws") {
							if (ltIndex >= lt_1_1awsMessages.length) {
								ltIndex = 0;
								lxyNow++;
								IsLtShow = false;
							}
						}
						if (faceman == "az") {
							IsLtShow = false;
						}
						if (faceman == "wcs") {
							IsLtShow = false;
						}
						if (faceman == "xh") {
							IsLtShow = false;
						}
					}
					if (lxyNow==2) {
						if (faceman=="aws") {
							if (ltIndex >=lt_1_0awsMessages.length) {
								ltIndex = 0;
								IsLtShow = false;
							} 
						}
						if (faceman=="az") {
							IsLtShow = false;
						}
						if (faceman=="wcs") {
							if (ltIndex >= lt_1_wcsMessages.length) {
								ltIndex = 0;
								IsLtShow = false;
								lxyNow++;
							} 
						}
						if (faceman=="xh") {
							IsLtShow = false;
						}
					}
					if (lxyNow==3) {
						if (faceman=="aws") {
							if (ltIndex >=lt_1_0awsMessages.length) {
								ltIndex = 0;
								IsLtShow = false;
							} 
						}
						if (faceman=="az") {
							IsLtShow = false;
						}
						if (faceman=="wcs") {
							if (ltIndex >=lt_2_wcsMessages.length) {
								ltIndex = 0;
								IsLtShow = false;
							} 
						}
						if (faceman=="xh") {
							if (ltIndex >= lt_1_xhMessages.length) {
								ltIndex = 0;
								IsLtShow = false;
								lxyNow++;
							} 
						}
					}
					if (lxyNow==4) {
						if (faceman=="aws") {
							if (ltIndex >=lt_1_0awsMessages.length) {
								ltIndex = 0;
								IsLtShow = false;
							} 
						}
						if (faceman=="az") {
							if (ltIndex >= lt_1_azMessages.length) {
								ltIndex = 0;
								IsLtShow = false;
								lxyNow++;
							} 
						}
						if (faceman=="wcs") {
							if (ltIndex >=lt_2_wcsMessages.length) {
								ltIndex = 0;
								IsLtShow = false;
							} 
						}
						if (faceman=="xh") {
							IsLtShow = false;
						}
					}
					if (lxyNow==5) {
						if (faceman=="aws") {
							if (ltIndex >=lt_1_0awsMessages.length) {
								ltIndex = 0;
								IsLtShow = false;
							} 
						}
						if (faceman=="wcs") {
							if (ltIndex >= lt_3_wcsMessages.length) {
								ltIndex = 0;
								IsLtShow = false;
								lxyNow++;
							} 
						}
						if (faceman=="az") {
							IsLtShow = false;
						}
					}
					if (lxyNow==6) {
						if (faceman=="aws") {
							if (ltIndex >= lt_2_1awsMessages.length) {
								ltIndex = 0;
								IsLtShow = false;
								lxyNow++;
							} 
						}
						if (faceman=="wcs") {
							IsLtShow = false;
						}
					}
					if (lxyNow==7) {
						if (faceman=="aws") {
							if (ltIndex >= lt_2_0awsMessages.length) {
								ltIndex = 0;
								IsLtShow = false;
								if (FishNum>=5) {
									lxyNow++;
								}
							} 
						}
						if (faceman=="wcs") {
							IsLtShow = false;
						}
					}
					if (lxyNow==8) {
						if (faceman=="aws") {
							if (ltIndex >= lt_3_1awsMessages.length) {
								ltIndex = 0;
								IsLtShow = false;
								lxyNow++;
							} 
						}
						if (faceman=="wcs") {
							IsLtShow = false;
						}
					}
				}
			}else {
				if (KeyCode == KeyEvent.VK_UP) {
					isUp = true;
					Dir1 = KeyCode;
				} else if (KeyCode == KeyEvent.VK_LEFT) {
					isLeft = true;
					Dir1 = KeyCode;
				} else if (KeyCode == KeyEvent.VK_RIGHT) {
					isRight = true;
					Dir1 = KeyCode;
				} else if (KeyCode == KeyEvent.VK_DOWN) {
					isDown = true;
					Dir1 = KeyCode;
				} else if (KeyCode == KeyEvent.VK_V) {
					isHighSpeed = !isHighSpeed;
				}
				if (KeyCode == KeyEvent.VK_SPACE) {
					if (MapId==1) {
						FaceMan_Sure();
					}
					if (MapId==0) {
						MapId++;
					}
					
				}
				if (KeyCode == KeyEvent.VK_T) {
					isTitle = !isTitle;
				}
				
				if (KeyCode==KeyEvent.VK_A) {
					MapId=0;
					Red_yg=100;
					Hurt_yg=20;
					DefensivePower_yg=10;
					death_yg=false;
				}
			}
		}	
		 


		// ===========================================================
		// ��ȡ����״ֵ̬��ʵ�����ǵ��˶�״̬
		Move_LiXiaoYao();
		// ================================================================
		// ��������ң�ƶ���Χ
		Range_LiXiaoYao();
		// ������Ҵ�ͼƬ�ƶ���Χ
		ljcX = Range_X_BackGround(ljcX, ljcImage.getWidth(null));
		ljcY = Range_Y_BackGround(ljcY, ljcImage.getHeight(null));
		// ʵ����Ҵ��ƶ�
		ljcX = Move_X(ljcX, ljcImage.getWidth(null));
		ljcY = Move_Y(ljcY, ljcImage.getHeight(null));

	}
	//�ж�faceman+��������
	private void FaceMan_Sure() {
		int x = lxyX;
		int y = lxyY;
		int awsx2 = awsX + ljcX + awsImages[awsIndex].getWidth(null);
		int awsy2 = awsY + ljcY + awsImages[awsIndex].getHeight(null);
		int awsx1 = awsx2 - 100;
		int awsy1 = awsy2 - 60;
		// --------------����----------
		int azx2 = azX + ljcX + azImages[azIndex].getWidth(null);
		int azy2 = azY + ljcY + azImages[azIndex].getHeight(null)-20;
		int azx1 = azx2 + 68;
		int azy1 = azy2 - 100;
		// -------------����ɩ-------------
		int wcsx2 = wcsX + ljcX + wcsImages[wcsIndex].getWidth(null)+30;
		int wcsy2 = wcsY + ljcY + wcsImages[wcsIndex].getHeight(null)-50;
		int wcsx1 = wcsx2 - 68;
		int wcsy1 = wcsy2 - 50;
		//---------------С��-----------------
		int xhx2 = xhX + ljcX + xhImages[xhIndex].getWidth(null);
		int xhy2 = xhY + ljcY + xhImages[xhIndex].getHeight(null);
		int xhx1 = xhx2 - 100;
		int xhy1 = xhy2 - 60;
		// =======================
//				System.out.println(Dir1);
//				System.out.println(
//						"x " + x + " x1 " + xhx1 + " x2 " + xhx2 + " y " + lxyY + " y1 " + xhy1 + " y2 " + xhy2);
//				System.out.println(IsLtShow);
//				System.out.println(Dir1);
		if (Dir1 == KeyEvent.VK_UP && x > awsx1 && awsy1 < y && x < awsx2 && y < awsy2) {
			IsLtShow = true;
			faceman = "aws";
		}
		if (Dir1 == KeyEvent.VK_LEFT && x > azx2 && azy1 < y && x < azx1 && y < azy2 && lxyNow<=5) {
			IsLtShow = true;
			faceman = "az";
		}
		if (Dir1 == KeyEvent.VK_LEFT && x > wcsx1 && wcsy1 < y && x < wcsx2 && y < wcsy2) {
			IsLtShow = true;
			faceman = "wcs";
		}
		if (Dir1 == KeyEvent.VK_UP && x > xhx1 && xhy1 < y && x < xhx2 && y < xhy2 && lxyNow<=4) {
			IsLtShow = true;
			faceman = "xh";
		}
	}

	// ʵ�ֱ�����ͼ�ƶ�
	private int Move_X(int X1, int X_BackGround) {
		if (lxyX <= 300 && X1 < 0) {
			if (isHighSpeed == false) {
				X1 += Speed;
				lxyX += Speed;
			} else {
				X1 += HighSpeed;
				lxyX += HighSpeed;
			}
		}
		if (lxyX >= 600 && X1 > 1024 - X_BackGround) {
			if (isHighSpeed == false) {
				lxyX -= Speed;
				X1 -= Speed;
			} else {
				lxyX -= HighSpeed;
				X1 -= HighSpeed;
			}
		}
		return X1;
	}

	private int Move_Y(int Y, int Y_BackGround) {
		if (lxyY <= 300 && Y < 0) {
			if (isHighSpeed == false) {
				lxyY += Speed;
				Y += Speed;
			} else {
				lxyY += HighSpeed;
				Y += HighSpeed;
			}
		}
		if (lxyY >= 500 && Y > 768 - Y_BackGround) {
			if (isHighSpeed == false) {
				lxyY -= Speed;
				Y -= Speed;
			} else {
				lxyY -= HighSpeed;
				Y -= HighSpeed;
			}
		}
		return Y;

	}

	// ������Ҵ�ͼƬ�ƶ���Χ
	private int Range_X_BackGround(int X1, int X_BackGround) {
		if (X1 >= 0) {
			X1 = 0;
		}

		if (X1 <= 1024 - X_BackGround) {
			X1 = 1024 - X_BackGround;
		}
		return X1;

	}

	private int Range_Y_BackGround(int Y1, int Y_BackGround) {
		if (Y1 >= 0) {
			Y1 = 0;
		}
		if (Y1 <= 768 - Y_BackGround) {
			Y1 = 768 - Y_BackGround;
		}
		return Y1;
	}

	// ��������ң�ƶ���Χ
	private void Range_LiXiaoYao() {
		if (lxyX <= 0) {
			lxyX = 0;
		}
		if (lxyX >= 960) {
			lxyX = 960;
		}
		if (lxyY <= 0) {
			lxyY = 0;
		}
		if (lxyY >= 630) {
			lxyY = 630;
		}
	}

	// ����ң���ƶ�����+�ϰ�����
	private void Move_LiXiaoYao() {
		if (IsLtShow == false) {
			if (isDown == true) {
				if (isHighSpeed == false) {
					lxyY += Speed;
					// ����ϰ���
					int x = lxyX - ljcX + lxyImage.getWidth(null) / 2;
					int y = lxyY - ljcY + lxyImage.getHeight(null);
					if (ljcDateImage.getRGB(x, y) == -521461) {
						lxyY -= Speed;
					}
				} else {
					lxyY += HighSpeed;
					// ����ϰ���
					int x = lxyX - ljcX + lxyImage.getWidth(null) / 2;
					int y = lxyY - ljcY + lxyImage.getHeight(null);
					if (ljcDateImage.getRGB(x, y) == -521461) {
						lxyY -= HighSpeed;
					}
				}
				repaint();
				lxyIndex++;
				if (lxyIndex >= down_lxyImages.length) {
					lxyIndex = 0;
				}
				// ----------
				if (isLeft == false && isRight == false) {
					lxyImage = down_lxyImages[lxyIndex];
				} else if (isLeft == true) {
					lxyImage = Down_Left_lxyImages[lxyIndex];
					if (isHighSpeed == false) {
						lxyX -= Speed;
						// ����ϰ���
						x = lxyX - ljcX + lxyImage.getWidth(null) / 2;
						y = lxyY - ljcY + lxyImage.getHeight(null);
						if (ljcDateImage.getRGB(x, y) == -521461) {
							lxyX += Speed;
						}
					} else {
						lxyX -= HighSpeed;
						// ����ϰ���
						x = lxyX - ljcX + lxyImage.getWidth(null) / 2;
						y = lxyY - ljcY + lxyImage.getHeight(null);
						if (ljcDateImage.getRGB(x, y) == -521461) {
							lxyX += HighSpeed;
						}
					}
				} else if (isRight == true) {
					lxyImage = Down_Right_lxyImages[lxyIndex];
					if (isHighSpeed == false) {
						lxyX += Speed;
						// ����ϰ���
						x = lxyX - ljcX + lxyImage.getWidth(null) / 2;
						y = lxyY - ljcY + lxyImage.getHeight(null);
						if (ljcDateImage.getRGB(x, y) == -521461) {
							lxyX -= Speed;
						}
					} else {
						lxyX += HighSpeed;
						// ����ϰ���
						x = lxyX - ljcX + lxyImage.getWidth(null) / 2;
						y = lxyY - ljcY + lxyImage.getHeight(null);
						if (ljcDateImage.getRGB(x, y) == -521461) {
							lxyX -= HighSpeed;
						}
					}
				}
				// ================================
			} else {
				if (isLeft == true) {
					if (isHighSpeed == false) {
						lxyX -= Speed;
						// ����ϰ���
						x = lxyX - ljcX + lxyImage.getWidth(null) / 2;
						y = lxyY - ljcY + lxyImage.getHeight(null);
						if (ljcDateImage.getRGB(x, y) == -521461) {
							lxyX += Speed;
						}
					} else {
						lxyX -= HighSpeed;
						// ����ϰ���
						x = lxyX - ljcX + lxyImage.getWidth(null) / 2;
						y = lxyY - ljcY + lxyImage.getHeight(null);
						if (ljcDateImage.getRGB(x, y) == -521461) {
							lxyX += HighSpeed;
						}
					}
					repaint();
					lxyIndex++;
					if (lxyIndex >= left_lxyImages.length) {
						lxyIndex = 0;
					}
					// ------------
					if (isUp == false) {
						lxyImage = left_lxyImages[lxyIndex];
					} else if (isUp == true) {
						lxyImage = Up_Left_lxyImages[lxyIndex];
						if (isHighSpeed == false) {
							lxyY -= Speed;
							// ����ϰ���
							x = lxyX - ljcX + lxyImage.getWidth(null) / 2;
							y = lxyY - ljcY + lxyImage.getHeight(null);
							if (ljcDateImage.getRGB(x, y) == -521461) {
								lxyY += Speed;
							}
						} else {
							lxyY -= HighSpeed;
							// ����ϰ���
							x = lxyX - ljcX + lxyImage.getWidth(null) / 2;
							y = lxyY - ljcY + lxyImage.getHeight(null);
							if (ljcDateImage.getRGB(x, y) == -521461) {
								lxyY += HighSpeed;
							}
						}
					}
					// ================================
				} else {
					if (isRight == true) {
						if (isHighSpeed == false) {
							lxyX += Speed;
							// ����ϰ���
							x = lxyX - ljcX + lxyImage.getWidth(null) / 2;
							y = lxyY - ljcY + lxyImage.getHeight(null);
							if (ljcDateImage.getRGB(x, y) == -521461) {
								lxyX -= Speed;
							}
						} else {
							lxyX += HighSpeed;
							// ����ϰ���
							x = lxyX - ljcX + lxyImage.getWidth(null) / 2;
							y = lxyY - ljcY + lxyImage.getHeight(null);
							if (ljcDateImage.getRGB(x, y) == -521461) {
								lxyX -= HighSpeed;
							}
						}
						repaint();
						lxyIndex++;
						if (lxyIndex >= right_lxyImages.length) {
							lxyIndex = 0;
						}
						if (isUp == false) {
							lxyImage = right_lxyImages[lxyIndex];
						} else if (isUp == true) {
							lxyImage = Up_Right_lxyImages[lxyIndex];
							if (isHighSpeed == false) {
								lxyY -= Speed;
								// ����ϰ���
								x = lxyX - ljcX + lxyImage.getWidth(null) / 2;
								y = lxyY - ljcY + lxyImage.getHeight(null);
								if (ljcDateImage.getRGB(x, y) == -521461) {
									lxyY += Speed;
								}
							} else {
								lxyY -= HighSpeed;
								// ����ϰ���
								x = lxyX - ljcX + lxyImage.getWidth(null) / 2;
								y = lxyY - ljcY + lxyImage.getHeight(null);
								if (ljcDateImage.getRGB(x, y) == -521461) {
									lxyY += HighSpeed;
								}
							}
						}
						// ===============================
					} else {
						if (isUp == true) {
							if (isHighSpeed == false) {
								lxyY -= Speed;
								// ����ϰ���
								x = lxyX - ljcX + lxyImage.getWidth(null) / 2;
								y = lxyY - ljcY + lxyImage.getHeight(null);
								if (ljcDateImage.getRGB(x, y) == -521461) {
									lxyY += Speed;
								}
							} else {
								lxyY -= HighSpeed;
								// ����ϰ���
								x = lxyX - ljcX + lxyImage.getWidth(null) / 2;
								y = lxyY - ljcY + lxyImage.getHeight(null);
								if (ljcDateImage.getRGB(x, y) == -521461) {
									lxyY += HighSpeed;
								}
							}
							repaint();
							lxyIndex++;
							if (lxyIndex >= up_lxyImages.length) {
								lxyIndex = 0;
							}
							lxyImage = up_lxyImages[lxyIndex];
						}
					}
				}
			}
		}
	}

	// �����ɿ��ķ���
	@Override
	public void keyReleased(KeyEvent e) {
		// DirSure();
		// ���̰������ɿ�
		int KeyCode = e.getKeyCode();
		if (KeyCode == KeyEvent.VK_UP) {
			isUp = false;
		}
		if (KeyCode == KeyEvent.VK_DOWN) {
			isDown = false;
		}
		if (KeyCode == KeyEvent.VK_LEFT) {
			isLeft = false;
		}
		if (KeyCode == KeyEvent.VK_RIGHT) {
			isRight = false;
		}
	}

	@Override
	public void keyTyped(KeyEvent e) {

	}

}
