# 🏨 Aplicativo Hotel (.NET MAUI)  

![.NET 7](https://img.shields.io/badge/.NET-7.0-blueviolet)  
![MAUI](https://img.shields.io/badge/Mobile-MAUI-ff69b4)  
![Status](https://img.shields.io/badge/Status-Concluído-brightgreen)      
![License](https://img.shields.io/badge/Licença-MIT-blue)  

**Repositório do aplicativo de reservas** desenvolvido para o projeto *Sistema de Gestão Hoteleira* da disciplina *Desenvolvimento de Sistemas II*.  

Aplicativo para reserva de suítes, com cálculo automático de diárias, seleção de período e controle de hóspedes.  

✔ **Interface moderna com tema escuro personalizado**  
✔ **Seleção de tipo de suíte e período de estadia**  
✔ **Cálculo automático do valor total**  
✔ **Validação de datas e ocupação**  

---  

## 📝 Descrição do Projeto  

Sistema de reservas para hotel com as seguintes funcionalidades:  

- **Cadastro de hóspedes** (adultos e crianças)  
- **Seleção de suítes** (Suíte SuperLuxo, Suíte Luxo, Suíte Single, Suíte Crise)  
- **Cálculo de diárias** com base no período selecionado  
- **Visualização do valor total** em tempo real  

---  

## ✨ Recursos Implementados  

✅ **Seleção de datas com DatePicker**  
✅ **Cálculo automático do valor da estadia**  
✅ **Layout responsivo para mobile e desktop**  
✅ **Tema escuro com cores personalizadas**  
✅ **Navegação entre telas** (seleção de suíte → confirmação)  

---  

## 🛠 Tecnologias Utilizadas  

- **Front-end**: XAML (MAUI)  
- **Back-end**: C# (lógica de reservas e cálculos)  
- **Plataforma**: .NET MAUI (Multi-platform App UI)  

---  

## 📂 Estrutura do Projeto  

```  
AppHotel/  
├── Views/  
│   ├── MainPage.xaml          # Tela inicial (seleção de suíte)  
│   ├── AppPage.xaml   # Tela de resumo da reserva  
├── Models/  
│   ├── Quarto.cs               # Modelo de dados da suíte  
│   ├──Hospedagem.cs             # Lógica de cálculo de diárias  
├── Styles/  
│   ├── Colors.xaml            # Paleta de cores do tema  
│   ├── Styles.xaml            # Estilos globais  
├── App.xaml                   # Configurações da aplicação  
└── README.md                  # Esta documentação  
```  

---  

## 🚀 Como Executar  

1. **Pré-requisitos**:  
   - .NET 7.0 SDK instalado  
   - Visual Studio 2022 (com suporte ao MAUI)  

2. **Clone o repositório**:  
   ```bash  
   git clone https://github.com/seuusuario/AppHotel.git  
   ```  

3. **Execute o projeto**:  
   ```bash  
   dotnet build  
   dotnet run --project AppHotel  
   ```  

4. **Teste no emulador Android, iOS ou Windows**  

---  

## 📌 Informações Acadêmicas  

| Item           | Detalhe                                  |  
| -------------- | ---------------------------------------- |  
| **Disciplina** | Desenvolvimento de Sistemas II           |  
| **Curso**      | Técnico em Desenvolvimento de Sistemas   |  
| **Objetivo**   | Sistema de reservas para hotelaria       |  

---  

> ✨ **Dica**: Personalize as cores no arquivo `Colors.xaml` para adequar ao branding do hotel!  
