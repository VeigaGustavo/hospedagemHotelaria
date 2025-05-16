# Sistema de Hospedagem e Hotelaria

Este é um sistema simples de gerenciamento de hospedagem em C# que permite cadastrar hóspedes, suítes e realizar reservas.

## Funcionalidades

- Cadastro de hóspedes com nome e sobrenome
- Cadastro de suítes com tipo, capacidade e valor da diária
- Realização de reservas com verificação de capacidade
- Cálculo automático do valor total da hospedagem
- Desconto de 10% para reservas com 10 dias ou mais

## Estrutura do Projeto

O projeto está organizado da seguinte forma:

### Classes Principais

1. **Pessoa**
   - Propriedades: Nome, Sobrenome, NomeCompleto
   - Construtores para diferentes formas de inicialização

2. **Suite**
   - Propriedades: TipoSuite, Capacidade, ValorDiaria
   - Configuração completa da suíte

3. **Reserva**
   - Propriedades: Hospedes, Suite, DiasReservados
   - Métodos para gerenciar reservas e cálculos

## Como Executar

1. Certifique-se de ter o .NET SDK instalado
2. Clone o repositório
3. Navegue até a pasta do projeto
4. Execute o comando:
   ```bash
   dotnet run
   ```

## Exemplo de Uso

```csharp
// Criar hóspedes
Pessoa hospede1 = new Pessoa(nome: "Hospede 1");
Pessoa hospede2 = new Pessoa(nome: "Hospede 2");

// Criar lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();
hospedes.Add(hospede1);
hospedes.Add(hospede2);

// Criar suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Criar reserva
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);
```

## Regras de Negócio

1. **Capacidade da Suíte**
   - O sistema verifica se a quantidade de hóspedes não excede a capacidade da suíte
   - Lança exceção se a capacidade for excedida

2. **Cálculo de Valores**
   - Valor total = Dias reservados × Valor diária
   - Desconto de 10% para reservas com 10 dias ou mais

## Tecnologias Utilizadas

- C#
- .NET 6.0 ou superior
