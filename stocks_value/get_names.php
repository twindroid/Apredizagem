<?php

$apiKey = '9VH3XLL76VIFDIVI'; // Substitua pelo seu próprio API Key do Alpha Vantage
$keywords = 'technology'; // Palavras-chave para pesquisar símbolos de ações

// URL da API para pesquisar símbolos de ações
$url = "https://www.alphavantage.co/query?function=SYMBOL_SEARCH&keywords=$keywords&apikey=$apiKey";

// Fazendo a solicitação GET
$response = file_get_contents($url);

// Verificando se a solicitação foi bem-sucedida
if ($response === false) {
    die("Erro ao fazer a solicitação para pesquisar símbolos de ações.");
}

// Decodificando a resposta JSON
$data = json_decode($response, true);

// Verificando se os dados foram obtidos corretamente
if (!isset($data['bestMatches'])) {
    die("Não foi possível obter os símbolos de ações.");
}

// Obtendo os símbolos de ações encontrados
$matches = $data['bestMatches'];

// Exibindo os símbolos de ações
foreach ($matches as $match) {
    echo "Símbolo: " . $match['1. symbol'] . "\n";
    echo "Nome: " . $match['2. name'] . "\n";
    echo "Tipo: " . $match['3. type'] . "\n";
    echo "Região: " . $match['4. region'] . "\n";
    echo "-------------------------\n";
}
