-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 22-Ago-2020 às 21:07
-- Versão do servidor: 10.4.13-MariaDB
-- versão do PHP: 7.2.32

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `loginfuturocomissario`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

CREATE TABLE `usuario` (
  `Id` int(11) NOT NULL,
  `Nome` varchar(50) DEFAULT NULL,
  `Sobrenome` varchar(50) DEFAULT NULL,
  `Sexo` varchar(10) DEFAULT NULL,
  `Dia` int(11) DEFAULT NULL,
  `Mes` int(11) DEFAULT NULL,
  `Ano` varchar(10) DEFAULT NULL,
  `Rua` varchar(50) DEFAULT NULL,
  `Numero` int(11) DEFAULT NULL,
  `Complemento` varchar(50) DEFAULT NULL,
  `Cep` varchar(10) DEFAULT NULL,
  `Estado` varchar(2) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Senha` varchar(7) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`Id`, `Nome`, `Sobrenome`, `Sexo`, `Dia`, `Mes`, `Ano`, `Rua`, `Numero`, `Complemento`, `Cep`, `Estado`, `Email`, `Senha`) VALUES
(1, NULL, NULL, NULL, 0, 0, NULL, NULL, 0, NULL, NULL, NULL, '12', '12'),
(2, NULL, NULL, 'Feminino', 0, 1, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL),
(3, '123', '123', 'Feminino', 1, 1, '123', '123', 123, '123', '123', 'MG', '123', '123'),
(4, 'Silva', '123', 'Feminino', 3, 8, '1234', 'fref', 3, 'ferfref', '1234', 'MG', 'Silva', 'Silva'),
(5, NULL, NULL, 'Feminino', 0, 1, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL),
(6, 'Maria', 'jgrerl', 'Feminino', 4, 1, '1234', 'fkksdrf', 32, 'kf', '12345', 'MG', 'Maria', 'Maria'),
(7, NULL, NULL, NULL, 0, 0, NULL, NULL, 0, NULL, NULL, NULL, 'g', 'r');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
