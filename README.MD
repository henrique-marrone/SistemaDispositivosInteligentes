# 💡 Sistema de Dispositivos Inteligentes

Projeto desenvolvido em **C#** com o objetivo de praticar conceitos fundamentais de Programação Orientada a Objetos (POO), por meio da implementação de um sistema de gerenciamento de dispositivos inteligentes.

A aplicação permite cadastrar, controlar e configurar diferentes dispositivos, como luminárias e aparelhos de ar-condicionado, utilizando conceitos de herança, encapsulamento, polimorfismo e sobrecarga de métodos.

## 🚀 Funcionalidades

- Cadastro de luminárias e aparelhos de ar-condicionado.
- Listagem de dispositivos cadastrados.
- Ativação de um ou múltiplos dispositivos.
- Desativação dos dispositivos.
- Ajuste da intensidade da iluminação.
- Ajuste da temperatura do ar-condicionado.
- Validação de entradas do usuário.
- Menu interativo via terminal.

## 🛠️ Tecnologias utilizadas

- C#
- .NET 8
- Programação Orientada a Objetos
- Git e GitHub

## 📚 Conceitos aplicados

| Conceito | Aplicação no projeto |
|---|---|
| Encapsulamento | Proteção dos atributos por meio de propriedades. |
| Herança | Luminaria e ArCondicionado herdam de Dispositivo. |
| Polimorfismo | Sobrescrita dos métodos Ligar() e Desligar(). |
| Sobrecarga | Diferentes implementações do método Ativar() na classe Controlador. |
| Listas | Gerenciamento dos dispositivos com List<Dispositivo>. |
| Arrays | Ativação de múltiplos dispositivos por meio de arrays. |
| Tratamento de entradas | Validação de dados utilizando TryParse(). |

## 📁 Estrutura do projeto

```text
SistemaDispositivosInteligentes/
│
├── ArCondicionado.cs
├── Controlador.cs
├── Dispositivo.cs
├── Luminaria.cs
├── Program.cs
├── SistemaDispositivosInteligentes.csproj
├── .gitignore
└── README.md
```

## ⚙️ Como executar

### Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Git (opcional, para clonar o repositório).

### 1. Clone o repositório

```bash
git clone URL_DO_REPOSITORIO
```

### 2. Entre na pasta do projeto

```bash
cd SistemaDispositivosInteligentes
```

### 3. Compile a aplicação

```bash
dotnet build
```

### 4. Execute o projeto

```bash
dotnet run
```

## 🎯 Objetivo

Este projeto faz parte da minha jornada de aprendizado em desenvolvimento de software, com foco no aprofundamento em C#, Programação Orientada a Objetos e construção de aplicações organizadas e funcionais.

---

Desenvolvido por **Henrique Takahashi**.