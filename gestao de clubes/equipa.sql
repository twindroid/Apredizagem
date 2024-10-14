-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 10-Abr-2023 às 00:56
-- Versão do servidor: 10.4.24-MariaDB
-- versão do PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `vnf20736`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `equipa`
--

CREATE TABLE `equipa` (
  `id` int(11) NOT NULL,
  `nome` text NOT NULL,
  `golos` int(11) NOT NULL,
  `vitorias` int(11) NOT NULL,
  `derrotas` int(11) NOT NULL,
  `empates` int(11) NOT NULL,
  `jogos` int(11) NOT NULL,
  `golos_s` int(11) NOT NULL,
  `jogadores` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `equipa`
--

INSERT INTO `equipa` (`id`, `nome`, `golos`, `vitorias`, `derrotas`, `empates`, `jogos`, `golos_s`, `jogadores`) VALUES
(1, 'Sport Lisboa e Benfica', 0, 0, 0, 0, 0, 0, 23),
(5, 'Futebol Clube do Porto', 0, 0, 0, 0, 0, 0, 23),
(6, 'Sporting Clube de Braga', 0, 0, 0, 0, 0, 0, 23),
(7, 'Sporting Clube de Portugal', 0, 0, 0, 0, 0, 0, 23),
(8, 'Rio Ave', 0, 0, 0, 0, 0, 0, 23),
(9, 'Portimonense', 0, 0, 0, 0, 0, 0, 23),
(10, 'Futebol Clube Vizela', 0, 0, 0, 0, 0, 0, 23);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `equipa`
--
ALTER TABLE `equipa`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `equipa`
--
ALTER TABLE `equipa`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
