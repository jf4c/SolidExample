# ✨ Arquitetura Limpa Com .NET - Balta.io

> Esse repositorio tem como objetivo servir de carderno de anotação para os
conteudos passados no curso Arquitetura Limpa com .NET do Balta.io

---

## 🛠️ SOLID

### Single Responsability Principle (SRP)
- Uma classe deve ter um, e somente um, motivo para mudar.
- Uma classe deve ter apenas uma responsabilidade.
- Se uma classe tem mais de uma responsabilidade, ela deve ser dividida em classes menores.
- Exemplo: 
    - Classe de EmailService, que tem a responsabilidade de enviar email.
    - Classe de ClienteService, que tem a responsabilidade de gerenciar clientes.

### Open/Closed Principle (OCP)
- Uma classe deve estar aberta para extensão, mas fechada para modificação.
- Exemplo:
    - Utilizar interfaces para implementar novas funcionalidades.
    - Utilizar herança para criar novas classes.

### Liskov Substitution Principle (LSP)
- Objetos de uma superclasse devem ser substituíveis por objetos de suas subclasses sem que a aplicação quebre.
- Exemplo:
    - Se a classe A é um subtipo da classe B, então os objetos da classe B podem ser substituídos por objetos da classe A sem que a aplicação quebre.
    - Se a classe A é um subtipo da classe B, então os objetos da classe B podem ser substituídos por objetos da classe A sem que a aplicação quebre.
  
### Interface Segregation Principle (ISP)
- Uma classe não deve ser forçada a implementar interfaces que ela não utiliza.
- Interfaces devem ser coesas.
- Exemplo:
    - Criar interfaces com métodos específicos para cada classe.

### Dependency Inversion Principle (DIP)
- Dependa de abstrações e não de implementações.
- Módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender de abstrações.
- Abstrações não devem depender de detalhes. Detalhes devem depender de abstrações.
- Exemplo:
    - Utilizar interfaces para fazer a comunicação entre as classes.
    - Utilizar injeção de dependência.
