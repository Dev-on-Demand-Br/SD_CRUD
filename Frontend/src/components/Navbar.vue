<template>
<nav class="navbar navbar-expand-lg bg-body-tertiary rounded" aria-label="Thirteenth navbar example">
      <div class="container-fluid">
        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarsExample11" aria-controls="navbarsExample11" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>

        <div class="collapse navbar-collapse d-lg-flex" id="navbarsExample11">
          <router-link class="navbar-brand col-lg-3 me-0" to="/">SD_CRUD</router-link>
          <ul class="navbar-nav col-lg-6 justify-content-lg-center">

            <li class="nav-item">
              <router-link class="nav-link active" aria-current="page" to="/">Home</router-link>
            </li>

            <li class="nav-item">
              <router-link class="nav-link" to="/Produtos">Produtos</router-link>
            </li>
            <li class="nav-item">
              <a class="nav-link disabled">Em breve</a>
            </li>

            <li class="nav-item dropdown">
              <a class="nav-link dropdown-toggle" href="#" data-bs-toggle="dropdown" aria-expanded="false">Cadastros</a>
              <ul class="dropdown-menu">
            <li><router-link class="dropdown-item" to="/CadastroProduto">Cadastro de Produtos</router-link></li>
            <li><router-link class="dropdown-item" to="/CadastroCategoria">Cadastro de Categorias</router-link></li>
            <li><a class="dropdown-item disabled" href="#">Em breve</a></li>
          </ul>
            </li>
          </ul>
          <div class="d-lg-flex col-lg-3 justify-content-lg-end">
            <button class="btn btn-primary">Login</button>
          </div>
        </div>
      </div>
    </nav>
</template>

<script>
export default {
    name: "Navbar"
}
</script>

<style>

</style>