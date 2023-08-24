<?php

 include('conecao.php');

 if (empty($_POST['usuario']) || empty($_POST['senha'])){
 	
 	header('Location : index.php');
 	exit();}

 

 $usuario = mysqli_real_escape_string($conecao, $_POST['usuario']);
 $senha = mysqli_real_escape_string($conecao, $_POST['senha']);

 $query = "select usuario from usuarioSite where usuario = '$usuario' and senha = md5('$senha');"; 
 // teste echo $query; exit; 

 $result = mysqli_query($conecao, $query);

 $row = mysqli_num_rows($result);
 // teste echo $row; exit;


 if ($row == 1) {
 	$_SESSION['usuario'] = $usuario;
 	header('Location: painel.php');
 	exit();
 }else{

 	//$_SESSION['nao_autenticado'] = false;
 	header('Location: index.php');
 	exit();

 }


?>