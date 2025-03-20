# Cabelo & Cia

## Sobre o Projeto

**Cabelo & Cia** é um sistema web desenvolvido com ASP.NET MVC para gerenciamento de um salão de beleza. O sistema permite o cadastro e gerenciamento de clientes, agendamentos, serviços e profissionais.

## Tecnologias Utilizadas
- ASP.NET MVC (.NET 8.0)
- C#
- Entity Framework Core (ORM)
- MySQL (banco de dados)
- Bootstrap (Front-end)
- Identity para autenticação

## Requisitos
- .NET 8.0 SDK
- Banco de dados MySQL configurado

## Instalação e Execução

1. Clone o repositório:
   ```sh
   git clone https://github.com/seu-usuario/Cabelo-Cia-master.git
   cd Cabelo-Cia-master
   ```

2. Configure as variáveis de ambiente no arquivo `appsettings.json`:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Database=cabelocia;User=root;Password=sua_senha;"
     }
   }
   ```

3. Execute as migrações do banco de dados:
   ```sh
   dotnet ef database update
   ```

4. Inicie a aplicação:
   ```sh
   dotnet run
   ```

5. Acesse a aplicação no navegador:
   ```
   http://localhost:5000
   ```

## Funcionalidades
- Cadastro e gerenciamento de clientes
- Agendamento de horários
- Gerenciamento de serviços oferecidos
- Cadastro e controle de profissionais
- Autenticação e autorização de usuários

## Contribuição
Contribuições são bem-vindas! Para contribuir:
1. Fork o repositório
2. Crie uma branch (`git checkout -b feature/nova-funcionalidade`)
3. Commit suas alterações (`git commit -m 'Adicionando nova funcionalidade'`)
4. Envie para o repositório remoto (`git push origin feature/nova-funcionalidade`)
5. Abra um Pull Request

## Licença
Este projeto está sob a SRB-COMERCIAL.

---
Desenvolvido por Samuel Ribeiro Batista

