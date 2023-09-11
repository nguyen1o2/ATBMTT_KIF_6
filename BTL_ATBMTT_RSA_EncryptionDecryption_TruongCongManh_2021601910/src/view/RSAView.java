package view;

import java.util.Scanner;

import controller.RSAController;
import model.RSA;

public class RSAView {
	
	public static final Scanner sc = new Scanner(System.in);
	
	public static boolean menuTaoKhoa(RSAController rsaController) {
		boolean taoKhoaThanhCong = false;
		while (taoKhoaThanhCong == false) {
			System.out.println("\n\t\tRSA's MENU");
			System.out.println("(1) - Sinh khoa tu dong");
			System.out.println("(2) - Sinh khoa thu cong");
			System.out.println("(3) - Thoat");
			System.out.print("> Nhap lua chon cua ban: ");
			int choice = sc.nextInt();
			sc.nextLine();
			
			switch (choice) {
			case 1:
				taoKhoaThanhCong = rsaController.automaticKeyGeneration();
				break;
			case 2:
				taoKhoaThanhCong = rsaController.manualKeyGeneration();
				break;
			case 3:
				return false;
			default:
				System.out.println("Lua chon khong hop le. Vui long nhap lai!");
			}
		}
		return taoKhoaThanhCong;
	}
	
	public static void menuMaHoaGiaiMa(RSAController rsaController) {
		boolean taoKhoaThanhCong = false;
		taoKhoaThanhCong = menuTaoKhoa(rsaController);
		while (taoKhoaThanhCong) {
			System.out.println("\n\t\tRSA's MENU");
			System.out.println("(1) - Ma hoa");
			System.out.println("(2) - Giai ma");
			System.out.println("(3) - Tao khoa moi");
			System.out.print("> Nhap lua chon cua ban: ");
			int choice = sc.nextInt();
			sc.nextLine();
			
			String message, cipherText, plainText;
			
			switch (choice) {
			case 1:
				System.out.print("Enter plain text: ");
				message = sc.nextLine();
				cipherText = rsaController.encryptRSA(message);	// Mã hóa
				System.out.println("Encrypt: " + cipherText);
				break;
			case 2:
				System.out.print("Enter cipher text: ");
				cipherText = sc.nextLine();
				plainText = rsaController.decryptRSA(cipherText);	// Giải mã
				System.out.println("Decrypt: " + plainText);
				break;
			case 3:
				menuTaoKhoa(rsaController);
			default:
				System.out.println("Lua chon khong hop le. Vui long nhap lai!");
			}
		}
		
	}
	
	public static void main(String[] args) {
		RSA rsa = new RSA();
		RSAController rsaController = new RSAController(rsa);
		menuMaHoaGiaiMa(rsaController);
	}
}
