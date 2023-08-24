<?php
require "conecao.php"; 

$conexao = new PDO();
$conexao->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

$comandoSQL = $conexao->query("SELECT * FROM usuarioSite");

while($linha = $comandoSQL->fetch()){

	print $linha[1] . "<BR>";

}



?>