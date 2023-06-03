DROP SCHEMA IF EXISTS `erp` ;
CREATE SCHEMA IF NOT EXISTS `erp` DEFAULT CHARACTER SET utf8;
USE `erp`;

-- -----------------------------------------------------
-- Table `erp`.`countries`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`countries` (
    `country_id` INTEGER(11) NOT NULL AUTO_INCREMENT,
    `iso` CHAR(2) NOT NULL,
    `name` VARCHAR(80) NOT NULL,
    `iso3` CHAR(3) DEFAULT NULL,
    `numcode` SMALLINT(6) DEFAULT NULL,
    `phonecode` INTEGER(5) NOT NULL,

  PRIMARY KEY(`country_id`)
);

-- -----------------------------------------------------
-- Table `erp`.`addresses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`addresses` (
    `address_id` INTEGER NOT NULL AUTO_INCREMENT,
    `street` VARCHAR(50) NOT NULL,
    `house_number` INTEGER NOT NULL,
    `city` VARCHAR(50) NOT NULL,
    `state` VARCHAR(255),
    `postal_code` VARCHAR(8) NOT NULL,
    `country_id` INTEGER NOT NULL,

    PRIMARY KEY(`address_id`),
    FOREIGN KEY(`country_id`) REFERENCES `erp`.`countries`(`country_id`)
);

-- -----------------------------------------------------
-- Table `erp`.`customers`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`customers` (
    `customer_id` INTEGER NOT NULL AUTO_INCREMENT,
    `customer_number` INTEGER NOT NULL,
    `username` VARCHAR(50) NOT NULL,
	`password` VARCHAR(255) NOT NULL,
	`salt` VARCHAR(255) NOT NULL,
	`origin` VARCHAR(255) NOT NULL,
    `salutation` INTEGER NOT NULL,
    `first_name` VARCHAR(50) NOT NULL,
    `last_name` VARCHAR(50) NOT NULL,
    `email` VARCHAR(50) NOT NULL,
    `telefon` VARCHAR (50),
    `standard_payment_method` VARCHAR(50) NOT NULL,
    `standard_delivery_method` VARCHAR(50) NOT NULL,
    `delivery_address_id` INTEGER,
    `billing_address_id` INTEGER,
    `registration_date` DATETIME NOT NULL,
    `last_login`DATETIME NOT NULL,
    `customer_status` INTEGER NOT NULL DEFAULT 0,
    `customer_group` INTEGER NOT NULL DEFAULT 0,
    `comment` TEXT NOT NULL DEFAULT '',

    PRIMARY KEY (`customer_id`),
    FOREIGN KEY (`delivery_address_id`) REFERENCES `erp`.`addresses`(`address_id`) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (`billing_address_id`) REFERENCES `erp`.`addresses`(`address_id`) ON DELETE CASCADE ON UPDATE CASCADE
); 

-- -----------------------------------------------------
-- Table `erp`.`invoices`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`invoices` (
    `invoice_id` INTEGER NOT NULL AUTO_INCREMENT,
    `invoice_number` INTEGER NOT NULL,
    `total_price` INTEGER NOT NULL,
    `tax` INTEGER NOT NULL,

    PRIMARY KEY(`invoice_id`)
);

-- -----------------------------------------------------
-- Table `erp`.`sizes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`sizes` (
    `size_id` INTEGER NOT NULL AUTO_INCREMENT,
    `length` DECIMAL NOT NULL,
    `width` DECIMAL NOT NULL,
    `height` DECIMAL NOT NULL,
    `volume` DECIMAL NOT NULL,

    PRIMARY KEY(`size_id`)
);

-- -----------------------------------------------------
-- Table `erp`.`discounts`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`discounts` (
    `discount_id` INTEGER NOT NULL AUTO_INCREMENT,
    `discount_code` VARCHAR(36) NOT NULL,
    `start_date` DATETIME NOT NULL,
    `expiration_date` DATETIME NOT NULL,

    PRIMARY KEY(`discount_id`)
);

-- -----------------------------------------------------
-- Table `erp`.`orders`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`orders` (
    `order_id` INTEGER NOT NULL AUTO_INCREMENT,
    `order_number` VARCHAR(50) NOT NULL,
    `customer_id` INTEGER NOT NULL,
    `invoice_id` INTEGER NOT NULL,
    `size_id` INTEGER NOT NULL,
    `weight` DECIMAL NOT NULL,
    `payment_method` VARCHAR(50) NOT NULL,
    `shipping_method` VARCHAR(50) NOT NULL,
    `delivery_address_id` INTEGER NOT NULL,
    `billing_address_id` INTEGER NOT NULL,
    `order_date` DATETIME NOT NULL,
    `delivery_date` DATETIME NOT NULL,
    `invoice_date` DATETIME NOT NULL,
    `order_status_public` INTEGER NOT NULL,
    `order_status_intern` INTEGER NOT NULL,
    `discount_id` INTEGER NOT NULL,
    `order_note` TEXT NOT NULL DEFAULT '',

    PRIMARY KEY(`order_id`),
    FOREIGN KEY(`customer_id`) REFERENCES `erp`.`customers`(`customer_id`),
    FOREIGN KEY(`invoice_id`) REFERENCES `erp`.`invoices`(`invoice_id`),
    FOREIGN KEY(`size_id`) REFERENCES `erp`.`sizes`(`size_id`) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY(`delivery_address_id`) REFERENCES `erp`.`addresses`(`address_id`) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY(`billing_address_id`) REFERENCES `erp`.`addresses`(`address_id`) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY(`discount_id`) REFERENCES `erp`.`discounts`(`discount_id`)
);

-- -----------------------------------------------------
-- Table `erp`.`articles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`articles` (
    `article_id` INTEGER NOT NULL AUTO_INCREMENT,
    `article_number` VARCHAR(12) NOT NULL,
    `name` VARCHAR(50) NOT NULL,
    `description` TEXT NOT NULL DEFAULT '',
    `size_id` INTEGER NOT NULL,
    `weight` DECIMAL NOT NULL,
    `purchase_price` DECIMAL NOT NULL,
    `selling_price` DECIMAL NOT NULL,
    `inclusion_date` DATETIME NOT NULL,
    `is_bundle` BOOLEAN NOT NULL DEFAULT FALSE,

    PRIMARY KEY(`article_id`),
    FOREIGN KEY (`size_id`) REFERENCES `erp`.`sizes`(`size_id`) ON DELETE CASCADE ON UPDATE CASCADE
);

-- -----------------------------------------------------
-- Table `erp`.`order_articles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`order_articles` (
    `order_id` INTEGER NOT NULL,
    `article_id` INTEGER NOT NULL,
    `count` INTEGER NOT NULL,
    `purchase_price_on_order` DECIMAL NOT NULL,
    `selling_price_on_order` DECIMAL NOT NULL,

    PRIMARY KEY(`order_id`, `article_id`),
    FOREIGN KEY(`order_id`) REFERENCES `erp`.`orders`(`order_id`) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY(`article_id`) REFERENCES `erp`.`articles`(`article_id`) ON DELETE CASCADE ON UPDATE CASCADE
);

-- -----------------------------------------------------
-- Table `erp`.`categories`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`categories` (
    `category_id` INTEGER NOT NULL AUTO_INCREMENT,
    `name` VARCHAR(50),
    `description` TEXT NOT NULL DEFAULT '',
    
    PRIMARY KEY(`category_id`)
);

-- -----------------------------------------------------
-- Table `erp`.`article_categories`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`article_categories` (
    `article_id` INTEGER NOT NULL,
    `category_id` INTEGER NOT NULL,
    
    PRIMARY KEY(`article_id`, `category_id`),
    FOREIGN KEY (`article_id`) REFERENCES `erp`.`articles`(`article_id`) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (`category_id`) REFERENCES `erp`.`categories`(`category_id`) ON DELETE CASCADE ON UPDATE CASCADE
);

-- -----------------------------------------------------
-- Table `erp`.`materials`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`materials` (
    `material_id` INTEGER NOT NULL AUTO_INCREMENT,
    `name` VARCHAR(50),
    `description` TEXT NOT NULL DEFAULT '',
    
    PRIMARY KEY(`material_id`)
);

-- -----------------------------------------------------
-- Table `erp`.`article_materials`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`article_materials` (
    `article_id` INTEGER NOT NULL,
    `material_id` INTEGER NOT NULL,
    
    PRIMARY KEY(`article_id`, `material_id`),
    FOREIGN KEY (`article_id`) REFERENCES `erp`.`articles`(`article_id`) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (`material_id`) REFERENCES `erp`.`materials`(`material_id`) ON DELETE CASCADE ON UPDATE CASCADE
);

-- -----------------------------------------------------
-- Table `erp`.`bundle_articles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`bundle_articles` (
    `bundle_id` INTEGER NOT NULL,
    `article_id` INTEGER NOT NULL,

    PRIMARY KEY(`bundle_id`, `article_id`),
	FOREIGN KEY (`bundle_id`) REFERENCES `erp`.`articles`(`article_id`) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (`article_id`) REFERENCES `erp`.`articles`(`article_id`) ON DELETE CASCADE ON UPDATE CASCADE
);

-- -----------------------------------------------------
-- Table `erp`.`warehouses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`warehouses` (
    `warehouse_id` INTEGER NOT NULL AUTO_INCREMENT,
    `name` VARCHAR(50) NOT NULL,
    `number` INTEGER NOT NULL,
    `address_id` INTEGER NOT NULL,

    PRIMARY KEY(`warehouse_id`),
    FOREIGN KEY (`address_id`) REFERENCES `erp`.`addresses`(`address_id`) ON DELETE CASCADE ON UPDATE CASCADE
);

-- -----------------------------------------------------
-- Table `erp`.`sections`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`sections` (
    `section_id` INTEGER NOT NULL AUTO_INCREMENT,
    `warehouse_id` INTEGER NOT NULL,
    `name` VARCHAR(50) NOT NULL,
    `number` INTEGER NOT NULL,
    `sort_number` INTEGER NOT NULL,

    PRIMARY KEY(`section_id`),
    FOREIGN KEY(`warehouse_id`) REFERENCES `erp`.`warehouses`(`warehouse_id`) ON DELETE CASCADE ON UPDATE CASCADE
);

-- -----------------------------------------------------
-- Table `erp`.`rows`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`rows` (
    `row_id` INTEGER NOT NULL AUTO_INCREMENT,
    `warehouse_id` INTEGER NOT NULL,
    `section_id` INTEGER NOT NULL,
    `name` VARCHAR(50) NOT NULL,
    `number` INTEGER NOT NULL,
    `sort_number` INTEGER NOT NULL,

    PRIMARY KEY(`row_id`),
    FOREIGN KEY(`warehouse_id`) REFERENCES `erp`.`warehouses`(`warehouse_id`) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY(`section_id`) REFERENCES `erp`.`sections`(`section_id`) ON DELETE CASCADE ON UPDATE CASCADE
);

-- -----------------------------------------------------
-- Table `erp`.`racks`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`racks` (
    `rack_id` INTEGER NOT NULL AUTO_INCREMENT,
    `warehouse_id` INTEGER NOT NULL,
    `section_id` INTEGER NOT NULL,
    `row_id` INTEGER NOT NULL,
    `name` VARCHAR(50) NOT NULL,
    `number` INTEGER NOT NULL,
    `sort_number` INTEGER NOT NULL,

    PRIMARY KEY(`rack_id`),
    FOREIGN KEY(`warehouse_id`) REFERENCES `erp`.`warehouses`(`warehouse_id`) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY(`section_id`) REFERENCES `erp`.`sections`(`section_id`) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY(`row_id`) REFERENCES `erp`.`rows`(`row_id`) ON DELETE CASCADE ON UPDATE CASCADE
);

-- -----------------------------------------------------
-- Table `erp`.`compartments`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`compartments` (
    `compartment_id` INTEGER NOT NULL AUTO_INCREMENT,
    `warehouse_id` INTEGER NOT NULL,
    `section_id` INTEGER NOT NULL,
    `row_id` INTEGER NOT NULL,
    `rack_id` INTEGER NOT NULL,
    `name` VARCHAR(50) NOT NULL,
    `number` INTEGER NOT NULL,
    `sort_number` INTEGER NOT NULL,
    `article_id` INTEGER NOT NULL,
    `stock` INTEGER NULL,

    PRIMARY KEY(`compartment_id`),
    FOREIGN KEY(`warehouse_id`) REFERENCES `erp`.`warehouses`(`warehouse_id`) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY(`section_id`) REFERENCES `erp`.`sections`(`section_id`) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY(`row_id`) REFERENCES `erp`.`rows`(`row_id`) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY(`rack_id`) REFERENCES `erp`.`racks`(`rack_id`) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY(`article_id`) REFERENCES `erp`.`articles`(`article_id`)
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
    `last_login` DATETIME NOT NULL,

	PRIMARY KEY(`user_id`)
);

-- -----------------------------------------------------
-- Table `erp`.`permissons`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`permissions` (
	`permission_id` INTEGER NOT NULL AUTO_INCREMENT,
	`name` VARCHAR(50) NOT NULL,
	`identifier` VARCHAR(50) NOT NULL,
	`description` TEXT NOT NULL,

	PRIMARY KEY (`permission_id`)
);

-- -----------------------------------------------------
-- Table `erp`.`user_permissons`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `erp`.`user_permissions` (
	`user_id` INTEGER NOT NULL,
	`permission_id` INTEGER NOT NULL,

	PRIMARY KEY(`user_id`, `permission_id`),
	FOREIGN KEY (`user_id`) REFERENCES `erp`.`users`(`user_id`) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (`permission_id`) REFERENCES `erp`.`permissions`(`permission_id`) ON DELETE CASCADE ON UPDATE CASCADE
);