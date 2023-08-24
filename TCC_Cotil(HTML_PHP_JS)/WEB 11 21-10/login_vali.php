<?php 
// Conexão com o banco de dados 
require "conecao.php"; 
 
// Inicia sessões 
session_start(); 
 
// Recupera o login 
$usuario = isset($_POST["usuario"]) ? addslashes(trim($_POST["usuario"])) : FALSE; 
// Recupera a senha, a criptografando em MD5 
$senha = isset($_POST["senha"]) ? $_POST["senha"] : FALSE; 
 
// Usuário não forneceu a senha ou o login 
if(!$usuario || !$senha) 
{ 
    echo "Você deve digitar sua senha e login!"; 
    exit; 
} 

/** 
* Executa a consulta no banco de dados. 
* Caso o número de linhas retornadas seja 1 o login é válido, 
* caso 0, inválido. 
*/
$SQL = "SELECT usuario, senha " .
       "  FROM usuarioSite ".
       " WHERE usuario = '" . $usuario . "'"; 
$result_user = @mysqli_query($conexao, $SQL) or die("Erro no banco de dados!"); 
$total = @mysqli_num_rows($result_user); 

// Caso o usuário tenha digitado um login válido o número de linhas será 1.. 
if($total) 
{ 
    // Obtém os dados do usuário, para poder verificar a senha e passar os demais dados para a sessão 
    $dados = @mysqli_fetch_array($result_user); 
 
    // Agora verifica a senha 
    if(!strcmp($senha, $dados["senha"])) 
    { 
        // TUDO OK! Agora, passa os dados para a sessão e redireciona o usuário 
        $_SESSION["usuario"] = $dados["usuario"]; 
        //$_SESSION["email"]   = stripslashes($dados["mail"]); 
        $_SESSION["senha"]   = $dados["senha"]; 
        header("Location: carrinho.php"); 
        exit; 
    } 
    // Senha inválida 
    else
    { 
    ?>
        <script type="text/javascript">alert("Senha Inválida")</script>
          <div> Tela de Login: <a href="login.html" class="btn">Clique Aqui</a></div>-
    <?php
    exit; 
    } 
} 
    // Login inválido 
else
{ 
    echo "O login fornecido por você é inexistente!"; 
     print ("<br>");
   ?>
    <div> Tela de Cadastro:  <a href="cadastro.html" class="btn">Clique Aqui</a></div>
   <?php
     print ("<br>");
    echo "Caso esteja incorreto, tente novamente"; 
    print ("<br>");
   ?>
     <div> Tela de Login: <a href="login.html" class="btn">Clique Aqui</a></div>
   <?php
    exit; 
} 


$_SESSION['usuario'] = $usuario;
    $_SESSION['senha']   = $senha;0
?>