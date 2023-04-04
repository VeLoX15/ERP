DROP SCHEMA IF EXISTS `erp` ;
CREATE SCHEMA IF NOT EXISTS `erp` DEFAULT CHARACTER SET latin1 ;
USE `erp`;

-- -----------------------------------------------------
-- Table `erp`.`customers`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`customers` (
    `customer_id` INT NOT NULL AUTO_INCREMENT,
    `customer_number` INT NOT NULL,
    `user_name` VARCHAR(50) NOT NULL,
    `password` VARCHAR(50) NOT NULL,
    `salutation` INT NOT NULL,
    `first_name` VARCHAR(50) NOT NULL,
    `last_name` VARCHAR(50) NOT NULL,
    `email` VARCHAR(50) NOT NULL,
    `telefon` VARCHAR (50),
    `delivery_address_id` INT,
    `billing_address_id` INT,
    `registration_date` DATETIME NOT NULL,
    `is_blocked` INT NOT NULL DEFAULT 0,
    `comment` TEXT NOT NULL DEFAULT '',

    PRIMARY KEY (`customer_id`)
); 

-- -----------------------------------------------------
-- Table `erp`.`shopping_cart`
-- -----------------------------------------------------

CREATE TABLE IF NOT EXISTS `erp`.`shopping_cart` (
    `shopping_cart_id` INT NOT NULL AUTO_INCREMENT,

    PRIMARY KEY (`shopping_cart_id`)
); 

-- -----------------------------------------------------
-- Table `erp`.`addresses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`addresses` (
    `address_id` INT NOT NULL AUTO_INCREMENT,
    `customer_id` INT NOT NULL,
    `warehouse_id` INT NOT NULL,
    `street` VARCHAR(50) NOT NULL,
    `house_number` INT NOT NULL,
    `city` VARCHAR(50) NOT NULL,
    `zip_code` VARCHAR(8) NOT NULL,

    PRIMARY KEY(`address_id`),
    --FOREIGN KEY(`customer_id`) REFERENCES `erp`.`customers`(`customer_id`),
    --FOREIGN KEY(`warehouse_id`) REFERENCES `erp`.`warehouse`(`warehouse_id`)
);
-- -----------------------------------------------------
-- Table `erp`.`order`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`order` (
    `order_id` INT NOT NULL AUTO_INCREMENT,
    `order_number` INT NOT NULL,
    `customer_id` INT NOT NULL,
    `weight` DECIMAL NOT NULL,
    `payment_method` VARCHAR(50) NOT NULL,
    `shipping_method` VARCHAR(50) NOT NULL,
    `order_date` DATE NOT NULL,
    `delivery_date` DATE NOT NULL,
    `invoice_date` DATE NOT NULL,
    `status` INT NOT NULL,

    PRIMARY KEY(`order_id`),
    --FOREIGN KEY(`customer_id`) REFERENCES `erp`.`customers`(`customers_id`)
);

-- -----------------------------------------------------
-- Table `erp`.`countries`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`countries` (
  `country_id` INT(11) NOT NULL AUTO_INCREMENT,
  `iso` CHAR(2) NOT NULL,
  `name` VARCHAR(80) NOT NULL,
  `nicename` VARCHAR(80) NOT NULL,
  `iso3` CHAR(3) DEFAULT NULL,
  `numcode` smallint(6) DEFAULT NULL,
  `phonecode` int(5) NOT NULL,

  PRIMARY KEY(`country_id`)
);

-- -----------------------------------------------------
-- Table `erp`.`articles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`articles` (
    `article_id` INT NOT NULL AUTO_INCREMENT,
    `article_number` INT(12) NOT NULL,
    `name` VARCHAR(50) NOT NULL,
    `category_id` INT NOT NULL,
    `stock` INT NOT NULL,
    `description` TEXT NOT NULL DEFAULT '',
    `weight` DECIMAL NOT NULL,
    `length` DECIMAL NOT NULL,
    `inclusion_date` DATE NOT NULL,

    PRIMARY KEY(`article_id`)
);

-- -----------------------------------------------------
-- Table `erp`.`categories`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`categories` (
    `category_id` INT NOT NULL AUTO_INCREMENT,
    `article_id` INT NOT NULL,
    `name` VARCHAR(50),
    
    PRIMARY KEY(`category_id`),
    --FOREIGN KEY(`article_id`) REFERENCES `erp`.`articles`(`article_id`)
);

-- -----------------------------------------------------
-- Table `erp`.`items`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`items` (
    `item_id` INT NOT NULL AUTO_INCREMENT,
    `article_id` INT NOT NULL,
    `name` VARCHAR(50) NOT NULL,
    `stock` INT NOT NULL,
    `weight` DECIMAL NOT NULL,
    `length` DECIMAL NOT NULL,

    PRIMARY KEY(`item_id`),
    --FOREIGN KEY(`article_id`) REFERENCES `erp`.`articles`(`article_id`)
);

-- -----------------------------------------------------
-- Table `erp`.`warehouse`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`warehouse` (
    `warehouse_id` INT NOT NULL AUTO_INCREMENT,
    `name` VARCHAR(50) NOT NULL,
    `number` INT NOT NULL,
    `sort_number` INT NOT NULL,

    PRIMARY KEY(`warehouse_id`)
);

-- -----------------------------------------------------
-- Table `erp`.`section`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`section` (
    `section_id` INT NOT NULL AUTO_INCREMENT,
    `warehouse_id` INT NOT NULL,
    `name` VARCHAR(50) NOT NULL,
    `number` INT NOT NULL,
    `sort_number` INT NOT NULL,

    PRIMARY KEY(`section_id`),
    --FOREIGN KEY(`warehouse_id`) REFERENCES `erp`.`warehouse`(`warehouse_id`)
);

-- -----------------------------------------------------
-- Table `erp`.`row`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`row` (
    `row_id` INT NOT NULL AUTO_INCREMENT,
    `warehouse_id` INT NOT NULL,
    `section_id` INT NOT NULL,
    `name` VARCHAR(50) NOT NULL,
    `number` INT NOT NULL,
    `sort_number` INT NOT NULL,

    PRIMARY KEY(`row_id`),
    --FOREIGN KEY(`warehouse_id`) REFERENCES `erp`.`warehouse`(`warehouse_id`),
    --FOREIGN KEY(`section_id`) REFERENCES `erp`.`section`(`section_id`)
);

-- -----------------------------------------------------
-- Table `erp`.`rack`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`rack` (
    `rack_id` INT NOT NULL AUTO_INCREMENT,
    `warehouse_id` INT NOT NULL,
    `section_id` INT NOT NULL,
    `row_id` INT NOT NULL,
    `name` VARCHAR(50) NOT NULL,
    `number` INT NOT NULL,
    `sort_number` INT NOT NULL,

    PRIMARY KEY(`rack_id`),
    --FOREIGN KEY(`warehouse_id`) REFERENCES `erp`.`warehouse`(`warehouse_id`),
    --FOREIGN KEY(`section_id`) REFERENCES `erp`.`section`(`section_id`),
    --FOREIGN KEY(`row_id`) REFERENCES `erp`.`row`(`row_id`)
);

-- -----------------------------------------------------
-- Table `erp`.`compartment`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`compartment` (
    `compartment_id` INT NOT NULL AUTO_INCREMENT,
    `warehouse_id` INT NOT NULL,
    `section_id` INT NOT NULL,
    `row_id` INT NOT NULL,
    `rack_id` INT NOT NULL,
    `name` VARCHAR(50) NOT NULL,
    `number` INT NOT NULL,
    `sort_number` INT NOT NULL,

    PRIMARY KEY(`compartment_id`),
    --FOREIGN KEY(`warehouse_id`) REFERENCES `erp`.`warehouse`(`warehouse_id`),
    --FOREIGN KEY(`section_id`) REFERENCES `erp`.`section`(`section_id`),
    --FOREIGN KEY(`row_id`) REFERENCES `erp`.`row`(`row_id`),
    --FOREIGN KEY(`rack_id`) REFERENCES `erp`.`rack`(`rack_id`)
);

-- -----------------------------------------------------
-- Table `erp`.`users`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`users` (
	`user_id` INTEGER NOT NULL AUTO_INCREMENT,
	`username` VARCHAR(50) NOT NULL,
	`display_name` VARCHAR(100) NOT NULL,
	`active_directory_guid` VARCHAR(36),
	`email` VARCHAR(255) NOT NULL,
	`password` VARCHAR(255) NOT NULL,
	`salt` VARCHAR(255) NOT NULL,
	`origin` VARCHAR(5) NOT NULL,
	PRIMARY KEY(`user_id`)
);

-- -----------------------------------------------------
-- Table `erp`.`permissons`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`permissions` (
	`permission_id` INTEGER NOT NULL AUTO_INCREMENT,
	`name` VARCHAR(50) NOT NULL,
	`identifier` VARCHAR(50) NOT NULL,
	`description` text NOT NULL,
	PRIMARY KEY (`permission_id`)
);

-- -----------------------------------------------------
-- Table `erp`.`user_permissons`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`user_permissions` (
	`user_id` INTEGER NOT NULL,
	`permission_id` INTEGER NOT NULL,
	PRIMARY KEY(`user_id`, `permission_id`),
	--FOREIGN KEY (`user_id`) REFERENCES `erp`.`users`(`user_id`),
	--FOREIGN KEY (`permission_id`) REFERENCES `erp`.`permissions`(`permission_id`)
);