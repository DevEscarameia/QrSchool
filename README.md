# QR School 🎓📱

**QR School** é uma aplicação de gestão escolar desenvolvida para facilitar o processo de requisição e levantamento de material informático, como portáteis, através da utilização de cartões de identificação com QR Code atribuídos a cada aluno.

## 🚀 Funcionalidades Principais

- 📅 **Sistema de Reservas de Equipamento**
  - Permite reservar portáteis para diferentes horários, com verificação de disponibilidade.
  - Evita conflitos entre reservas com horários sobrepostos.
  - Controlo de limite máximo de 40 portáteis disponíveis.

- 🧑‍🎓 **Cartões de Identificação com QR Code**
  - Geração automática de cartões para alunos com QR Code único.
  - Associação imediata entre aluno e requisição ao ler o QR Code.

- 💻 **Levantamento de Equipamento**
  - Interface rápida para leitura do QR Code do aluno e do equipamento.
  - Armazena data, hora e IDs de aluno, professor e portátil.

- 🖨️ **Impressão de Cartões**
  - Seleção múltipla de cartões para impressão em lote.
  - Geração de PDFs com frente e verso dos cartões lado a lado, até 5 por página.

- 🔒 **Sistema de Acesso com Níveis**
  - **Nível 1 (Secretaria)**: Gestão de cartões de alunos.
  - **Nível 2 (Reprografia)**: Gestão de equipamentos e reservas.
  - **Nível 3 (Administrador)**: Acesso total ao sistema.

## 🏗️ Tecnologias Utilizadas

- **C# com Windows Forms**
- **SQLite** como base de dados local
- **iTextSharp** para geração de PDFs
- **PDFium Viewer** para pré-visualização de cartões
- **QRCodeGenerator** para criação de QR Codes

## 📂 Organização da Base de Dados

A base de dados contém tabelas como:

- `Alunos` – dados dos alunos e QR Code
- `Cartoes` – cartões gerados
- `Reservas` – pedidos de reserva
- `Levantamentos` – registo de entregas de equipamento
- `Portateis` – registo e estado dos computadores
- `Professores` – responsáveis pelas requisições

## 👨‍🏫 Caso de Utilização

1. O professor seleciona um dia e horário no calendário.
2. O sistema mostra os horários disponíveis e quantos portáteis estão reservados.
3. Ao reservar, associa-se automaticamente um aluno (via QR Code).
4. No dia da entrega, o técnico lê o QR Code do aluno e do portátil.
5. O levantamento é registado com data, hora e IDs.

## 📦 Instalação e Utilização

> *Nota: A aplicação é local e não requer internet. Para uso em rede, basta partilhar a base de dados SQLite.*

1. Clona o repositório:
   ```bash
   git clone https://github.com/DevEscarameia/qrschool.git
