<?php

define('HOST', '143.106.241.3');
define('USUARIO', 'cl18465');
define('SENHA', 'cl*29042002');
define('DB', 'cl18465');

$conexao = mysqli_connect(HOST, USUARIO, SENHA, DB) or die ('Não conectou parça');

?>