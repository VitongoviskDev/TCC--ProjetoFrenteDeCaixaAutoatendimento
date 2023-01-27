-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 30-Nov-2022 às 20:17
-- Versão do servidor: 10.4.27-MariaDB
-- versão do PHP: 7.4.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `frentecaixa`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `fc_activity`
--

CREATE TABLE `fc_activity` (
  `id` int(11) NOT NULL,
  `item` varchar(255) DEFAULT NULL,
  `date` date DEFAULT NULL,
  `hour` time(6) DEFAULT NULL,
  `userID` int(11) DEFAULT NULL,
  `type` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `fc_cards`
--

CREATE TABLE `fc_cards` (
  `id` int(11) NOT NULL,
  `owner` varchar(256) DEFAULT NULL,
  `number` varchar(20) DEFAULT NULL,
  `cvv` varchar(3) DEFAULT NULL,
  `expirationDate` varchar(7) DEFAULT NULL,
  `type` char(1) DEFAULT NULL,
  `amount` decimal(7,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `fc_cards`
--

INSERT INTO `fc_cards` (`id`, `owner`, `number`, `cvv`, `expirationDate`, `type`, `amount`) VALUES
(1, 'Vitor Campos', '5245 3690 1429 9484', '920', '11/2024', 'c', '1000.00'),
(2, 'Bruno Silencio', '5357 5408 0805 4863', '500', '11/2026', 'd', '1000.00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `fc_company`
--

CREATE TABLE `fc_company` (
  `id` int(11) NOT NULL,
  `FantasyName` varchar(256) DEFAULT NULL,
  `SocialReason` varchar(256) DEFAULT NULL,
  `Cnpj` varchar(18) DEFAULT NULL,
  `StateRegistration` varchar(15) DEFAULT NULL,
  `OpeningDate` varchar(20) DEFAULT NULL,
  `Site` varchar(256) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `Ddi` varchar(3) DEFAULT NULL,
  `Ddd` varchar(2) DEFAULT NULL,
  `PhoneNumber` varchar(10) DEFAULT NULL,
  `Complement` varchar(256) NOT NULL,
  `Adress` varchar(256) DEFAULT NULL,
  `ZipCode` varchar(10) DEFAULT NULL,
  `Number` varchar(10) DEFAULT NULL,
  `District` varchar(256) DEFAULT NULL,
  `City` varchar(256) DEFAULT NULL,
  `State` varchar(256) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `fc_documents`
--

CREATE TABLE `fc_documents` (
  `id` int(11) NOT NULL,
  `number` int(11) DEFAULT NULL,
  `serial` int(11) DEFAULT NULL,
  `companyId` int(11) DEFAULT NULL,
  `emissionDate` date DEFAULT NULL,
  `registration` int(11) DEFAULT NULL,
  `type` char(1) DEFAULT NULL,
  `cpf` varchar(20) NOT NULL,
  `totalValue` decimal(7,2) DEFAULT NULL,
  `itemsAmount` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `fc_items`
--

CREATE TABLE `fc_items` (
  `itemId` int(11) NOT NULL,
  `barCode` varchar(256) NOT NULL,
  `description` varchar(256) DEFAULT NULL,
  `amount` int(11) DEFAULT NULL,
  `unity` varchar(5) DEFAULT NULL,
  `unitaryValue` decimal(7,2) DEFAULT NULL,
  `st` varchar(5) DEFAULT NULL,
  `itemValue` decimal(7,2) DEFAULT NULL,
  `documentType` char(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `fc_itemsxdocuments`
--

CREATE TABLE `fc_itemsxdocuments` (
  `id` int(11) NOT NULL,
  `itemId` int(11) DEFAULT NULL,
  `documentId` int(11) DEFAULT NULL,
  `documentType` char(1) DEFAULT NULL,
  `amount` int(11) DEFAULT NULL,
  `totalValue` decimal(7,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `fc_products`
--

CREATE TABLE `fc_products` (
  `id` int(11) NOT NULL,
  `code` int(11) DEFAULT NULL,
  `activityAddedId` int(11) NOT NULL,
  `description` varchar(150) DEFAULT NULL,
  `Status` tinyint(1) DEFAULT NULL,
  `price` decimal(7,2) DEFAULT NULL,
  `barcode` varchar(50) DEFAULT NULL,
  `unity` varchar(10) DEFAULT NULL,
  `activityUpdatedId` int(11) NOT NULL,
  `storageLevelAlert` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `fc_users`
--

CREATE TABLE `fc_users` (
  `id` int(11) NOT NULL,
  `code` int(11) DEFAULT NULL,
  `username` varchar(50) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `login` varchar(100) DEFAULT NULL,
  `passwordHash` varchar(256) DEFAULT NULL,
  `passwordHashAdder` varchar(256) DEFAULT NULL,
  `profile` int(11) DEFAULT NULL,
  `status` tinyint(1) DEFAULT NULL,
  `isFirstAccess` tinyint(1) DEFAULT NULL,
  `activityAddedId` int(11) DEFAULT NULL,
  `activityLastUpdatedId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `fc_config`
--

CREATE TABLE `fc_config` (
  `email` varchar(256) NOT NULL,
  `password` varchar(256) NOT NULL,
  `passwordChanged` tinyint(1) DEFAULT NULL,
  `itemSoldOut` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `fc_activity`
--
ALTER TABLE `fc_activity`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `fc_cards`
--
ALTER TABLE `fc_cards`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `fc_company`
--
ALTER TABLE `fc_company`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `fc_documents`
--
ALTER TABLE `fc_documents`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `fc_items`
--
ALTER TABLE `fc_items`
  ADD PRIMARY KEY (`itemId`);

--
-- Índices para tabela `fc_itemsxdocuments`
--
ALTER TABLE `fc_itemsxdocuments`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `fc_products`
--
ALTER TABLE `fc_products`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `fc_users`
--
ALTER TABLE `fc_users`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `fc_config`
--
ALTER TABLE `fc_config`
  ADD PRIMARY KEY (`email`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `fc_activity`
--
ALTER TABLE `fc_activity`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `fc_cards`
--
ALTER TABLE `fc_cards`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `fc_company`
--
ALTER TABLE `fc_company`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `fc_documents`
--
ALTER TABLE `fc_documents`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `fc_items`
--
ALTER TABLE `fc_items`
  MODIFY `itemId` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `fc_itemsxdocuments`
--
ALTER TABLE `fc_itemsxdocuments`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `fc_products`
--
ALTER TABLE `fc_products`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `fc_users`
--
ALTER TABLE `fc_users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
