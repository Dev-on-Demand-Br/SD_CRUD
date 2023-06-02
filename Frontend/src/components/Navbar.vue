<template>
    <nav class="navbar navbar-expand-lg bg-body-tertiary" >
  <div class="container-fluid">
    <router-link class="navbar-brand" to="/">SD_CRUD</router-link>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarNav">
      <ul class="navbar-nav">
        <li class="nav-item">
          <router-link class="nav-link active" aria-current="page" to="/">Home</router-link>
        </li>

        <li class="nav-item">
          <router-link class="nav-link" to="/Produtos">Produtos</router-link>
        </li>

        <li class="nav-item dropdown">
          <a class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
            Cadastros
          </a>
          <ul class="dropdown-menu">
            <li><router-link class="dropdown-item" to="/CadastroProduto">Cadastro de Produtos</router-link></li>
            <li><router-link class="dropdown-item" to="/CadastroCategoria">Cadastro de categorias</router-link></li>
            <li><a class="dropdown-item disabled" href="#">Em breve</a></li>
          </ul>
        </li>
        
      </ul>
    </div>
  </div>
</nav>
</template>

<script>
export default {
    name: "Navbar"
}
</script>