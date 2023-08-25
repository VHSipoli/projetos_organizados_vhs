/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package control;

import java.util.ArrayList;
import java.util.Iterator;
import model.Usuario;

/**
 *
 * @author aluno
 */
public class ControlaUser {
    private ArrayList lista;
    
    public ControlaUser(){
    lista = new ArrayList();

}
    
    public Usuario adicionaUser(String nome, String senha){
        
        Usuario user = new Usuario();
        user.setNome(nome);
        user.setSenha(senha);
        
        lista.add(user);
        
        Iterator it = user.iterator();
        
        while(it.hasNext()){
            System.out.println(it.next());
        }
                
        
        /*Iterator<Usuario> userAsIterator = user.iterator();
             while (userAsIterator.hasNext()){
                    Usuario it = userAsIterator.next();
                    System.out.println(it.next());
                     
             }*/
        
        return user;
        
    }
    
    
}
