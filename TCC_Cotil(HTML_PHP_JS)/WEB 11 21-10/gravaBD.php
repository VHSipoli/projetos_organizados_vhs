<?php
//conecao do BD PDO

$conexao = new PDO("mysql:host=143.106.241.3;dbname=cl18483","cl18483","cl*03072002");

// host = ip do serve, barreto=usaário, senha=senha

//ativar o depurador de erros do PDO

$conexao->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

//variavel pela url
$usuario  = $_POST["Usuario"];
$email    = $_POST["Email"];
$senha    = $_POST["Senha"];

//insert normal do banco
$comandoSQL  = $conexao->prepare("INSERT INTO usuarioSite (usuario, email, senha)VALUES('" .$usuario. "','" .$email. "', '" .$senha. "' );");

$comandoSQL->execute();


 if ($row == 1) {
 	$_SESSION['Usuario'] = $usuario;
 	header('Location: cadastro.html');
 	exit();}else{
 		$_SESSION['Usuario'] = $usuario;
 	header('Location: login.html');
 	exit();
 	}




?>