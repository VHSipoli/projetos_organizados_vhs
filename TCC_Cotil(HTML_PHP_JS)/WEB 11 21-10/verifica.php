<?php 
require "conecao.php"; 
$result = mysqli_query($conexao, "SELECT * FROM usuarioSite WHERE usuario = ".$usuario." AND senha = ".$senha."");
// Inicia sessões 
session_start(); 
 
// Verifica se existe os dados da sessão de login 
if(!isset($_SESSION['usuario']) || !isset($_SESSION['senha'])) 
{ 
	$_SESSION['usuario'] = $usuario;
	$_SESSION['senha']   = $senha;
// Usuário não logado! Redireciona para a página de login 
header("Location: login.html"); 
exit; 
} else{header("Location: carrinho.php"); }
?>