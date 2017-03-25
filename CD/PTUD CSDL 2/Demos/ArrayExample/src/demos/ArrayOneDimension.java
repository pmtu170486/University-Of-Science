/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package demos;

import java.util.Scanner;

/**
 *
 * @author home
 */
public class ArrayOneDimension {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        // So dong mảng 2 chieu
        int m;
        // So cot mang 2 chieu
        int n;
        System.out.printf("Nhap so dong: ");
        m = sc.nextInt();
        System.out.printf("Nhap so cot: ");
        n = sc.nextInt();

        // Khai bao mang 1 chieu co kich thuoc n
        int[][] a = new int[m][n];
        nhapmang(a, m, n);
        xuat(a, m, n);
    }

    public static void nhapmang(int[][] a, int m, int n) {
        Scanner sc = new Scanner(System.in);
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                System.out.printf("Nhap phan tu tai dong %d cot %d: ", i, j);
                a[i][j] = sc.nextInt();
            }

        }
    }

    public static void xuat(int[][] a, int m, int n) {
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                System.out.printf("%4d", a[i][j]);
            }
            System.out.println();
        }
    }

}
