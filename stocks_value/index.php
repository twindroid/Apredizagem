<!DOCTYPE html>
<html>
<head>
    <title>Valores das Ações</title>
    <style>
        body {
            background-color: #292929;
            color: #ffffff;
            font-family: Arial, sans-serif;
        }
        
        table {
            width: 100%;
            border-collapse: collapse;
            font-family: Arial, sans-serif;
            border-radius: 10px;
            overflow: hidden;
        }
        
        th, td {
            border: 1px solid #444444;
            padding: 8px;
            text-align: left;
        }
        
        th {
            background-color: #333333;
            color: #ffffff;
        }
        
        tr:nth-child(even) {
            background-color: #444444;
        }
        
        tr:hover {
            background-color: #555555;
        }
        
        .button-container {
            display: flex;
            justify-content: center;
        }
        
        .button-container button {
            margin: 5px;
            background-color: #555555;
            color: #ffffff;
            border: none;
            border-radius: 5px;
            padding: 8px 12px;
            cursor: pointer;
        }
        
        .button-container button:hover {
            background-color: #777777;
        }
    </style>
</head>
<body>
    <h1 style="text-align: center;">Valores das Ações</h1>

    <?php
    $symbols = ['AAPL', 'GOOGL', 'MSFT', 'TSLA'];
    $apiKey = '9VH3XLL76VIFDIVI';

    $stockData = [];

    foreach ($symbols as $symbol) {
        $url = "https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol=$symbol&apikey=$apiKey";

        $response = file_get_contents($url);

        if ($response === false) {
            die("Erro ao fazer a solicitação para o símbolo: $symbol");
        }

        $data = json_decode($response, true);

        if (!isset($data['Global Quote'])) {
            die("Não foi possível obter os dados para o símbolo: $symbol");
        }

        $globalQuote = $data['Global Quote'];
        $stockData[$symbol] = [
            'symbol' => $globalQuote['01. symbol'],
            'open' => $globalQuote['02. open'],
            'high' => $globalQuote['03. high'],
            'low' => $globalQuote['04. low'],
            'price' => $globalQuote['05. price'],
            'volume' => $globalQuote['06. volume'],
            'latestTradingDay' => $globalQuote['07. latest trading day'],
            'previousClose' => $globalQuote['08. previous close'],
            'change' => $globalQuote['09. change'],
            'changePercent' => $globalQuote['10. change percent'],
        ];
    }
    ?>

    <table>
        <tr>
            <th>Símbolo</th>
            <th>Abertura</th>
            <th>Alta</th>
            <th>Baixa</th>
            <th>Preço</th>
            <th>Volume</th>
            <th>Último dia de negociação</th>
            <th>Fechamento anterior</th>
            <th>Variação</th>
            <th>Variação percentual</th>
            <th>Ações</th>
        </tr>

        <?php foreach ($stockData as $symbol => $stock) { ?>
            <tr>
                <td><?= $stock['symbol'] ?></td>
                <td><?= $stock['open'] ?></td>
                <td><?= $stock['high'] ?></td>
                <td><?= $stock['low'] ?></td>
                <td><?= $stock['price'] ?></td>
                <td><?= $stock['volume'] ?></td>
                <td><?= $stock['latestTradingDay'] ?></td>
                <td><?= $stock['previousClose'] ?></td>
                <td><?= $stock['change'] ?></td>
                <td><?= $stock['changePercent'] ?>%</td>
                <td>
                    <div class="button-container">
                        <button onclick="invest('<?= $stock['symbol'] ?>', <?= $stock['price'] ?>)">Investir</button>
                    </div>
                </td>
            </tr>
        <?php } ?>
    </table>

<script>
    function invest(symbol, price) {
        var investAmount = parseFloat(prompt("Digite o valor que você deseja investir:"));
        if (isNaN(investAmount)) {
            alert("Valor inválido. Por favor, insira um número válido.");
            return;
        }

        var quantity = investAmount / price;
        var sellPrice = parseFloat(prompt("Digite o preço de venda da ação:"));
        if (isNaN(sellPrice)) {
            alert("Valor inválido. Por favor, insira um número válido.");
            return;
        }

        var url = "https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol=" + symbol + "&apikey=<?= $apiKey ?>";
        fetch(url)
            .then(response => response.json())
            .then(data => {
                var globalQuote = data['Global Quote'];
                var currentPrice = parseFloat(globalQuote['05. price']);
                var profitLoss = (sellPrice - price) * quantity;
                var percentProfitLoss = (profitLoss / investAmount) * 100;

                alert("Investimento em " + symbol + ":\n\n" +
                    "Quantidade comprada: " + quantity.toFixed(2) + "\n" +
                    "Valor investido: $" + investAmount.toFixed(2) + "\n" +
                    "Preço de venda: $" + sellPrice.toFixed(2) + "\n" +
                    "Lucro/Prejuízo: $" + profitLoss.toFixed(2) + "\n" +
                    "Variação percentual: " + percentProfitLoss.toFixed(2) + "%");
            })
            .catch(error => {
                console.error("Erro ao obter o preço atual da ação:", error);
                alert("Ocorreu um erro ao obter o preço atual da ação. Por favor, tente novamente.");
            });
    }
</script>

</body>
</html>
