# Valorant Game User Settings Editor

Este é um programa simples em C# que permite editar as configurações gráficas do jogo **Valorant** diretamente no arquivo `GameUserSettings.ini`. O programa é baseado em linha de comando (console) e oferece uma interface fácil para modificar os parâmetros de desempenho e gráficos do jogo.

## Funcionalidades

- Modificar configurações gráficas do Valorant, como qualidade de resolução, sombras, texturas e efeitos, diretamente no arquivo `GameUserSettings.ini`.
- Permite personalizar cada parâmetro com base nas preferências do usuário para melhorar o desempenho do jogo.
- Oferece uma maneira simples de ajustar as configurações sem precisar editar manualmente o arquivo de configuração.

## Parâmetros que podem ser alterados

O programa permite que você altere os seguintes parâmetros do arquivo `GameUserSettings.ini`:

- **sg.ResolutionQuality**: Qualidade de resolução.
- **sg.ViewDistanceQuality**: Qualidade da distância de visualização.
- **sg.AntiAliasingQuality**: Qualidade do anti-aliasing.
- **sg.ShadowQuality**: Qualidade das sombras.
- **sg.PostProcessQuality**: Qualidade dos pós-processos (efeitos visuais).
- **sg.TextureQuality**: Qualidade das texturas.
- **sg.EffectsQuality**: Qualidade dos efeitos gráficos.
- **sg.FoliageQuality**: Qualidade da vegetação.
- **sg.ShadingQuality**: Qualidade do sombreamento.

## Como usar

### Pré-requisitos

- .NET Framework ou .NET Core/5+ instalado em sua máquina para compilar e executar o programa.
- Acesso de leitura e escrita ao arquivo `GameUserSettings.ini`, que está localizado no seguinte caminho padrão:

