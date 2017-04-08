/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package demos;

/**
 *
 * @author home
 */
public class HocSinhChuyen extends HocSinh{

    @Override
    public void xuatHoTen() {
        super.xuatHoTen();
        System.out.printf("ho ten: %s",hoTen.toUpperCase());        
    }
}
