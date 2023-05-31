# SD_CRUD

Sistema de estoque de produtos com CRUD, categorias e autenticação. Permite cadastrar, consultar, atualizar e excluir produtos.

## Padronização para elaboração do projeto:

Para manter a organização e a qualidade do código, é importante seguir os seguintes passos ao iniciar uma etapa:

1. Atualize a lista de referências remotas no repositório local com o comando Git Fetch:

```git
git pull
```

2. Criar uma Branch para a implementação:

```git
git checkout -b nome-da-branch
```

3. Realizar toda a implementação na Branch criada:

```git
git add .
git commit -m "Descrição das alterações realizadas"
```

4. Após a finalização, realizar um Pull Request para que o código gerado seja revisado:

```git
# Subir as alterações da branch para o repositório remoto
git push origin nome-da-branch
```

Em seguida, na plataforma de hospedagem do repositório, crie um Pull Request da Branch criada para a Branch Main.

5. Se estiver tudo certo, realizar o Merge para a Branch Main:

```git
# Voltar para a branch main
git checkout main
```

6. Manter o projeto sempre funcional e limpo.

Caso tenha dúvidas ou não esteja familiarizado com esse fluxo de trabalho, recomendamos assistir ao seguinte conteúdo: [RocketSeat](https://app.rocketseat.com.br/discover/course/github-para-times).

Em caso de dúvidas, entre em contato pelo Whatsapp ou Discord.

## Tecnologias utilizadas

<img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/vuejs/vuejs-original-wordmark.svg" width="50" height="50" /> [Documentação](https://vuejs.org/guide/introduction.html)

<img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dotnetcore/dotnetcore-original.svg" width="50" height="50" /> [Documentação](https://learn.microsoft.com/pt-br/dotnet/)

## Objetivos do Trabalho

Criar uma aplicação de Estoque de Produtos.

1. Requisitos Mínimos:

- Modelo Produto: Implementar um modelo para representar os produtos do estoque.
- Modelo Categoria: Implementar um modelo para categorizar os produtos.
- Cadastrar um produto: Permitir adicionar um novo produto ao estoque.
- Consultar um produto: Possibilitar a visualização dos detalhes de um produto específico.
- Consultar Lista de produtos: Apresentar uma lista com todos os produtos cadastrados.
- Deletar um produto: Permitir remover um produto do estoque.
- Alterar um produto: Permitir atualizar as informações de um produto.
- Página /Produtos: Implementar de uma página que exibe a lista de produtos.
- Página /Produto: Implementar de uma página que exibe os detalhes de um produto.

2. Requisitos Extras:

- Listar Produtos por categoria: Adicionar a funcionalidade de filtrar os produtos por categoria.
- Tela de Login simples: Implementação de uma tela básica de login para acesso ao sistema.

3. Ordem de criação:

- Modelos: Criação dos modelos necessários para representar os produtos e categorias.
- Data Context: Implementação do contexto de dados para realizar operações no banco de dados.
- Controller: Desenvolvimento dos controladores que lidam com as requisições e respostas do sistema.
- Service: Criação dos serviços responsáveis pela lógica de negócio e manipulação dos dados.
- Páginas Razor: Implementação das páginas Web para exibir as informações e interagir com o usuário.

4. Páginas e Componentes Web Esperados:

- Landing Page

- Botão de Login
- Botão de Registro

- Página de Login
- Página de Registro

- Página de Lista de Produtos

- Botão de Cadastrar Categoria
- Página de Cadastro de Categoria

- Botão de Alterar Categoria
- Página de Alterar Categoria

- Botão de Deletar Categoria
- Popout de Confirmação

- Botão de Criar Produto
- Página de Criar Produto

- Botão de Alterar Produto
- Página de Alterar Produto

- Botão de Deletar Produto
- Popout de Confirmação
