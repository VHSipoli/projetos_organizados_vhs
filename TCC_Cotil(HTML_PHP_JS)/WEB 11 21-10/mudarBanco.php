<?php

require "conecao2.php"; 

session_start(); 
 
 //$conexao->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

 $comandoSQL  = $conexao->prepare("UPDATE Produtos SET Quantidade = Quantidade - 1 WHERE Id='23'");


 $comandoSQL->execute();





print_r("Comprado com Sucesso");








  ?>
     <div> Volte para o Inicio: <a href="index.html" class="btn">Clique Aqui</a></div>
   <?php
    exit; 



?>