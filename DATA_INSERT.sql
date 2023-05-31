#
# Core data for the ERP system of Tablebricks
# 
# Copyright (c) 2023 Tablebricks
#
#------------------------------------------------------------------
#

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;

USE `tabletop`;

#
# Dumping data for table 'permissions'
#

INSERT INTO `erp`.`permissions` (`permission_id`, `name`, `identifier`, `description`) VALUES (1, 'View Users', 'VIEW_USERS', '');
INSERT INTO `erp`.`permissions` (`permission_id`, `name`, `identifier`, `description`) VALUES (2, 'View Warhouses', 'VIEW_WAREHOUSES', '');
INSERT INTO `erp`.`permissions` (`permission_id`, `name`, `identifier`, `description`) VALUES (3, 'View Stocks', 'VIEW_STOCKS', '');
INSERT INTO `erp`.`permissions` (`permission_id`, `name`, `identifier`, `description`) VALUES (4, 'View Articles', 'VIEW_ARTICLES', '');
INSERT INTO `erp`.`permissions` (`permission_id`, `name`, `identifier`, `description`) VALUES (5, 'View Orders', 'VIEW_ORDERS', '');
INSERT INTO `erp`.`permissions` (`permission_id`, `name`, `identifier`, `description`) VALUES (6, 'View Customers', 'VIEW_CUSTOMERS', '');
INSERT INTO `erp`.`permissions` (`permission_id`, `name`, `identifier`, `description`) VALUES (7, 'View Statistics', 'VIEW_STATISTICS', '');
INSERT INTO `erp`.`permissions` (`permission_id`, `name`, `identifier`, `description`) VALUES (8, 'Edit Users', 'EDIT_USERS', '');
INSERT INTO `erp`.`permissions` (`permission_id`, `name`, `identifier`, `description`) VALUES (9, 'Edit Warehouses', 'EDIT_WAREHOUSES', '');
INSERT INTO `erp`.`permissions` (`permission_id`, `name`, `identifier`, `description`) VALUES (10, 'Edit Stocks', 'EDIT_STOCKS', '');
INSERT INTO `erp`.`permissions` (`permission_id`, `name`, `identifier`, `description`) VALUES (11, 'Edit Articles', 'EDIT_ARTICLES', '');
INSERT INTO `erp`.`permissions` (`permission_id`, `name`, `identifier`, `description`) VALUES (12, 'Edit Orders', 'EDIT_ORDERS', '');
INSERT INTO `erp`.`permissions` (`permission_id`, `name`, `identifier`, `description`) VALUES (13, 'Edit Customers', 'EDIT_CUSTOMERS', '');
INSERT INTO `erp`.`permissions` (`permission_id`, `name`, `identifier`, `description`) VALUES (14, 'Edit Statistics', 'EDIT_STATISTICS', '');
INSERT INTO `erp`.`permissions` (`permission_id`, `name`, `identifier`, `description`) VALUES (15, 'Delete Users', 'DELETE_USERS', '');
INSERT INTO `erp`.`permissions` (`permission_id`, `name`, `identifier`, `description`) VALUES (16, 'Delete Warehouses', 'DELETE_WAREHOUSES', '');
INSERT INTO `erp`.`permissions` (`permission_id`, `name`, `identifier`, `description`) VALUES (17, 'Delete Stocks', 'DELETE_STOCKS', '');
INSERT INTO `erp`.`permissions` (`permission_id`, `name`, `identifier`, `description`) VALUES (18, 'Delete Articles', 'DELETE_ARTICLES', '');
INSERT INTO `erp`.`permissions` (`permission_id`, `name`, `identifier`, `description`) VALUES (19, 'Delete Orders', 'DELETE_ORDERS', '');
INSERT INTO `erp`.`permissions` (`permission_id`, `name`, `identifier`, `description`) VALUES (20, 'Delete Customers', 'DELETE_CUSTOMERS', '');
INSERT INTO `erp`.`permissions` (`permission_id`, `name`, `identifier`, `description`) VALUES (21, 'Delete Statistics', 'DELETE_STATISTICS', '');
# 21 records

#
# Dumping data for table 'countries'
#

INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (1, 'AF', 'Afghanistan', 'AFG', 4, 93);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (2, 'AL', 'Albania', 'ALB', 8, 355);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (3, 'DZ', 'Algeria', 'DZA', 12, 213);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (4, 'AS', 'American Samoa', 'ASM', 16, 1684);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (5, 'AD', 'Andorra', 'AND', 20, 376);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (6, 'AO', 'Angola', 'AGO', 24, 244);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (7, 'AI', 'Anguilla', 'AIA', 660, 1264);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (8, 'AQ', 'Antarctica', NULL, NULL, 0);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (9, 'AG', 'Antigua and Barbuda', 'ATG', 28, 1268);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (10, 'AR', 'Argentina', 'ARG', 32, 54);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (11, 'AM', 'Armenia', 'ARM', 51, 374);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (12, 'AW', 'Aruba', 'ABW', 533, 297);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (13, 'AU', 'Australia', 'AUS', 36, 61);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (14, 'AT', 'Austria', 'AUT', 40, 43);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (15, 'AZ', 'Azerbaijan', 'AZE', 31, 994);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (16, 'BS', 'Bahamas', 'BHS', 44, 1242);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (17, 'BH', 'Bahrain', 'BHR', 48, 973);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (18, 'BD', 'Bangladesh', 'BGD', 50, 880);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (19, 'BB', 'Barbados', 'BRB', 52, 1246);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (20, 'BY', 'Belarus', 'BLR', 112, 375);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (21, 'BE', 'Belgium', 'BEL', 56, 32);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (22, 'BZ', 'Belize', 'BLZ', 84, 501);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (23, 'BJ', 'Benin', 'BEN', 204, 229);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (24, 'BM', 'Bermuda', 'BMU', 60, 1441);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (25, 'BT', 'Bhutan', 'BTN', 64, 975);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (26, 'BO', 'Bolivia', 'BOL', 68, 591);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (27, 'BA', 'Bosnia and Herzegovina', 'BIH', 70, 387);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (28, 'BW', 'Botswana', 'BWA', 72, 267);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (29, 'BV', 'Bouvet Island', NULL, NULL, 0);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (30, 'BR', 'Brazil', 'BRA', 76, 55);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (31, 'IO', 'British Indian Ocean Territory', NULL, NULL, 246);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (32, 'BN', 'Brunei Darussalam', 'BRN', 96, 673);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (33, 'BG', 'Bulgaria', 'BGR', 100, 359);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (34, 'BF', 'Burkina Faso', 'BFA', 854, 226);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (35, 'BI', 'Burundi', 'BDI', 108, 257);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (36, 'KH', 'Cambodia', 'KHM', 116, 855);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (37, 'CM', 'Cameroon', 'CMR', 120, 237);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (38, 'CA', 'Canada', 'CAN', 124, 1);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (39, 'CV', 'Cape Verde', 'CPV', 132, 238);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (40, 'KY', 'Cayman Islands', 'CYM', 136, 1345);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (41, 'CF', 'Central African Republic', 'CAF', 140, 236);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (42, 'TD', 'Chad', 'TCD', 148, 235);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (43, 'CL', 'Chile', 'CHL', 152, 56);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (44, 'CN', 'China', 'CHN', 156, 86);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (45, 'CX', 'Christmas Island', NULL, NULL, 61);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (46, 'CC', 'Cocos (Keeling) Islands', NULL, NULL, 672);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (47, 'CO', 'Colombia', 'COL', 170, 57);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (48, 'KM', 'Comoros', 'COM', 174, 269);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (49, 'CG', 'Congo', 'COG', 178, 242);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (50, 'CD', 'Congo, the Democratic Republic of the', 'COD', 180, 242);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (51, 'CK', 'Cook Islands', 'COK', 184, 682);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (52, 'CR', 'Costa Rica', 'CRI', 188, 506);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (53, 'CI', 'Cote D''Ivoire', 'CIV', 384, 225);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (54, 'HR', 'Croatia', 'HRV', 191, 385);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (55, 'CU', 'Cuba', 'CUB', 192, 53);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (56, 'CY', 'Cyprus', 'CYP', 196, 357);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (57, 'CZ', 'Czech Republic', 'CZE', 203, 420);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (58, 'DK', 'Denmark', 'DNK', 208, 45);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (59, 'DJ', 'Djibouti', 'DJI', 262, 253);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (60, 'DM', 'Dominica', 'DMA', 212, 1767);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (61, 'DO', 'Dominican Republic', 'DOM', 214, 1809);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (62, 'EC', 'Ecuador', 'ECU', 218, 593);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (63, 'EG', 'Egypt', 'EGY', 818, 20);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (64, 'SV', 'El Salvador', 'SLV', 222, 503);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (65, 'GQ', 'Equatorial Guinea', 'GNQ', 226, 240);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (66, 'ER', 'Eritrea', 'ERI', 232, 291);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (67, 'EE', 'Estonia', 'EST', 233, 372);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (68, 'ET', 'Ethiopia', 'ETH', 231, 251);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (69, 'FK', 'Falkland Islands (Malvinas)', 'FLK', 238, 500);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (70, 'FO', 'Faroe Islands', 'FRO', 234, 298);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (71, 'FJ', 'Fiji', 'FJI', 242, 679);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (72, 'FI', 'Finland', 'FIN', 246, 358);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (73, 'FR', 'France', 'FRA', 250, 33);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (74, 'GF', 'French Guiana', 'GUF', 254, 594);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (75, 'PF', 'French Polynesia', 'PYF', 258, 689);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (76, 'TF', 'French Southern Territories', NULL, NULL, 0);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (77, 'GA', 'Gabon', 'GAB', 266, 241);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (78, 'GM', 'Gambia', 'GMB', 270, 220);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (79, 'GE', 'Georgia', 'GEO', 268, 995);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (80, 'DE', 'Germany', 'DEU', 276, 49);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (81, 'GH', 'Ghana', 'GHA', 288, 233);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (82, 'GI', 'Gibraltar', 'GIB', 292, 350);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (83, 'GR', 'Greece', 'GRC', 300, 30);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (84, 'GL', 'Greenland', 'GRL', 304, 299);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (85, 'GD', 'Grenada', 'GRD', 308, 1473);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (86, 'GP', 'Guadeloupe', 'GLP', 312, 590);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (87, 'GU', 'Guam', 'GUM', 316, 1671);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (88, 'GT', 'Guatemala', 'GTM', 320, 502);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (89, 'GN', 'Guinea', 'GIN', 324, 224);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (90, 'GW', 'Guinea-Bissau', 'GNB', 624, 245);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (91, 'GY', 'Guyana', 'GUY', 328, 592);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (92, 'HT', 'Haiti', 'HTI', 332, 509);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (93, 'HM', 'Heard Island and Mcdonald Islands', NULL, NULL, 0);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (94, 'VA', 'Holy See (Vatican City State)', 'VAT', 336, 39);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (95, 'HN', 'Honduras', 'HND', 340, 504);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (96, 'HK', 'Hong Kong', 'HKG', 344, 852);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (97, 'HU', 'Hungary', 'HUN', 348, 36);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (98, 'IS', 'Iceland', 'ISL', 352, 354);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (99, 'IN', 'India', 'IND', 356, 91);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (100, 'ID', 'Indonesia', 'IDN', 360, 62);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (101, 'IR', 'Iran, Islamic Republic of', 'IRN', 364, 98);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (102, 'IQ', 'Iraq', 'IRQ', 368, 964);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (103, 'IE', 'Ireland', 'IRL', 372, 353);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (104, 'IL', 'Israel', 'ISR', 376, 972);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (105, 'IT', 'Italy', 'ITA', 380, 39);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (106, 'JM', 'Jamaica', 'JAM', 388, 1876);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (107, 'JP', 'Japan', 'JPN', 392, 81);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (108, 'JO', 'Jordan', 'JOR', 400, 962);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (109, 'KZ', 'Kazakhstan', 'KAZ', 398, 7);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (110, 'KE', 'Kenya', 'KEN', 404, 254);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (111, 'KI', 'Kiribati', 'KIR', 296, 686);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (112, 'KP', 'Korea, Democratic People''s Republic of', 'PRK', 408, 850);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (113, 'KR', 'Korea, Republic of', 'KOR', 410, 82);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (114, 'KW', 'Kuwait', 'KWT', 414, 965);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (115, 'KG', 'Kyrgyzstan', 'KGZ', 417, 996);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (116, 'LA', 'Lao People''s Democratic Republic', 'LAO', 418, 856);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (117, 'LV', 'Latvia', 'LVA', 428, 371);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (118, 'LB', 'Lebanon', 'LBN', 422, 961);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (119, 'LS', 'Lesotho', 'LSO', 426, 266);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (120, 'LR', 'Liberia', 'LBR', 430, 231);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (121, 'LY', 'Libyan Arab Jamahiriya', 'LBY', 434, 218);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (122, 'LI', 'Liechtenstein', 'LIE', 438, 423);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (123, 'LT', 'Lithuania', 'LTU', 440, 370);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (124, 'LU', 'Luxembourg', 'LUX', 442, 352);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (125, 'MO', 'Macao', 'MAC', 446, 853);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (126, 'MK', 'Macedonia, the Former Yugoslav Republic of', 'MKD', 807, 389);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (127, 'MG', 'Madagascar', 'MDG', 450, 261);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (128, 'MW', 'Malawi', 'MWI', 454, 265);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (129, 'MY', 'Malaysia', 'MYS', 458, 60);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (130, 'MV', 'Maldives', 'MDV', 462, 960);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (131, 'ML', 'Mali', 'MLI', 466, 223);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (132, 'MT', 'Malta', 'MLT', 470, 356);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (133, 'MH', 'Marshall Islands', 'MHL', 584, 692);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (134, 'MQ', 'Martinique', 'MTQ', 474, 596);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (135, 'MR', 'Mauritania', 'MRT', 478, 222);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (136, 'MU', 'Mauritius', 'MUS', 480, 230);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (137, 'YT', 'Mayotte', NULL, NULL, 269);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (138, 'MX', 'Mexico', 'MEX', 484, 52);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (139, 'FM', 'Micronesia, Federated States of', 'FSM', 583, 691);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (140, 'MD', 'Moldova, Republic of', 'MDA', 498, 373);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (141, 'MC', 'Monaco', 'MCO', 492, 377);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (142, 'MN', 'Mongolia', 'MNG', 496, 976);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (143, 'MS', 'Montserrat', 'MSR', 500, 1664);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (144, 'MA', 'Morocco', 'MAR', 504, 212);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (145, 'MZ', 'Mozambique', 'MOZ', 508, 258);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (146, 'MM', 'Myanmar', 'MMR', 104, 95);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (147, 'NA', 'Namibia', 'NAM', 516, 264);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (148, 'NR', 'Nauru', 'NRU', 520, 674);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (149, 'NP', 'Nepal', 'NPL', 524, 977);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (150, 'NL', 'Netherlands', 'NLD', 528, 31);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (151, 'AN', 'Netherlands Antilles', 'ANT', 530, 599);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (152, 'NC', 'New Caledonia', 'NCL', 540, 687);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (153, 'NZ', 'New Zealand', 'NZL', 554, 64);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (154, 'NI', 'Nicaragua', 'NIC', 558, 505);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (155, 'NE', 'Niger', 'NER', 562, 227);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (156, 'NG', 'Nigeria', 'NGA', 566, 234);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (157, 'NU', 'Niue', 'NIU', 570, 683);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (158, 'NF', 'Norfolk Island', 'NFK', 574, 672);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (159, 'MP', 'Northern Mariana Islands', 'MNP', 580, 1670);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (160, 'NO', 'Norway', 'NOR', 578, 47);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (161, 'OM', 'Oman', 'OMN', 512, 968);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (162, 'PK', 'Pakistan', 'PAK', 586, 92);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (163, 'PW', 'Palau', 'PLW', 585, 680);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (164, 'PS', 'Palestinian Territory, Occupied', NULL, NULL, 970);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (165, 'PA', 'Panama', 'PAN', 591, 507);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (166, 'PG', 'Papua New Guinea', 'PNG', 598, 675);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (167, 'PY', 'Paraguay', 'PRY', 600, 595);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (168, 'PE', 'Peru', 'PER', 604, 51);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (169, 'PH', 'Philippines', 'PHL', 608, 63);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (170, 'PN', 'Pitcairn', 'PCN', 612, 0);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (171, 'PL', 'Poland', 'POL', 616, 48);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (172, 'PT', 'Portugal', 'PRT', 620, 351);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (173, 'PR', 'Puerto Rico', 'PRI', 630, 1787);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (174, 'QA', 'Qatar', 'QAT', 634, 974);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (175, 'RE', 'Reunion', 'REU', 638, 262);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (176, 'RO', 'Romania', 'ROM', 642, 40);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (177, 'RU', 'Russian Federation', 'RUS', 643, 70);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (178, 'RW', 'Rwanda', 'RWA', 646, 250);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (179, 'SH', 'Saint Helena', 'SHN', 654, 290);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (180, 'KN', 'Saint Kitts and Nevis', 'KNA', 659, 1869);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (181, 'LC', 'Saint Lucia', 'LCA', 662, 1758);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (182, 'PM', 'Saint Pierre and Miquelon', 'SPM', 666, 508);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (183, 'VC', 'Saint Vincent and the Grenadines', 'VCT', 670, 1784);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (184, 'WS', 'Samoa', 'WSM', 882, 684);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (185, 'SM', 'San Marino', 'SMR', 674, 378);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (186, 'ST', 'Sao Tome and Principe', 'STP', 678, 239);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (187, 'SA', 'Saudi Arabia', 'SAU', 682, 966);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (188, 'SN', 'Senegal', 'SEN', 686, 221);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (189, 'CS', 'Serbia and Montenegro', NULL, NULL, 381);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (190, 'SC', 'Seychelles', 'SYC', 690, 248);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (191, 'SL', 'Sierra Leone', 'SLE', 694, 232);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (192, 'SG', 'Singapore', 'SGP', 702, 65);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (193, 'SK', 'Slovakia', 'SVK', 703, 421);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (194, 'SI', 'Slovenia', 'SVN', 705, 386);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (195, 'SB', 'Solomon Islands', 'SLB', 90, 677);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (196, 'SO', 'Somalia', 'SOM', 706, 252);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (197, 'ZA', 'South Africa', 'ZAF', 710, 27);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (198, 'GS', 'South Georgia and the South Sandwich Islands', NULL, NULL, 0);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (199, 'ES', 'Spain', 'ESP', 724, 34);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (200, 'LK', 'Sri Lanka', 'LKA', 144, 94);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (201, 'SD', 'Sudan', 'SDN', 736, 249);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (202, 'SR', 'Suriname', 'SUR', 740, 597);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (203, 'SJ', 'Svalbard and Jan Mayen', 'SJM', 744, 47);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (204, 'SZ', 'Swaziland', 'SWZ', 748, 268);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (205, 'SE', 'Sweden', 'SWE', 752, 46);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (206, 'CH', 'Switzerland', 'CHE', 756, 41);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (207, 'SY', 'Syrian Arab Republic', 'SYR', 760, 963);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (208, 'TW', 'Taiwan, Province of China', 'TWN', 158, 886);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (209, 'TJ', 'Tajikistan', 'TJK', 762, 992);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (210, 'TZ', 'Tanzania, United Republic of', 'TZA', 834, 255);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (211, 'TH', 'Thailand', 'THA', 764, 66);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (212, 'TL', 'Timor-Leste', NULL, NULL, 670);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (213, 'TG', 'Togo', 'TGO', 768, 228);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (214, 'TK', 'Tokelau', 'TKL', 772, 690);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (215, 'TO', 'Tonga', 'TON', 776, 676);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (216, 'TT', 'Trinidad and Tobago', 'TTO', 780, 1868);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (217, 'TN', 'Tunisia', 'TUN', 788, 216);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (218, 'TR', 'Turkey', 'TUR', 792, 90);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (219, 'TM', 'Turkmenistan', 'TKM', 795, 7370);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (220, 'TC', 'ISLANDS', 'Turks and Caicos Islands', 'TCA', 796, 1649);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (221, 'TV', 'Tuvalu', 'TUV', 798, 688);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (222, 'UG', 'Uganda', 'UGA', 800, 256);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (223, 'UA', 'Ukraine', 'UKR', 804, 380);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (224, 'AE', 'United Arab Emirates', 'ARE', 784, 971);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (225, 'GB', 'United Kingdom', 'GBR', 826, 44);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (226, 'US', 'United States', 'USA', 840, 1);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (227, 'UM', 'United States Minor Outlying Islands', NULL, NULL, 1);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (228, 'UY', 'Uruguay', 'URY', 858, 598);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (229, 'UZ', 'Uzbekistan', 'UZB', 860, 998);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (230, 'VU', 'Vanuatu', 'VUT', 548, 678);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (231, 'VE', 'Venezuela', 'VEN', 862, 58);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (232, 'VN', 'Viet Nam', 'VNM', 704, 84);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (233, 'VG', 'Virgin Islands, British', 'VGB', 92, 1284);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (234, 'VI', 'Virgin Islands, U.s.', 'VIR', 850, 1340);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (235, 'WF', 'Wallis and Futuna', 'WLF', 876, 681);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (236, 'EH', 'Western Sahara', 'ESH', 732, 212);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (237, 'YE', 'Yemen', 'YEM', 887, 967);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (238, 'ZM', 'Zambia', 'ZMB', 894, 260);
INSERT INTO `erp`.`countries` (`country_id`, `iso`, `name`, `iso3`, `numcode`, `phonecode`) VALUES (239, 'ZW', 'Zimbabwe', 'ZWE', 716, 263);
# 239 records

#
# Optional: Adds an admin user
#
#------------------------------------------------------------------
#

#
# Dumping data for table 'users'
#

INSERT INTO `erp`.`users` (`user_id`, `username`, `display_name`, `active_directory_guid`, `email`, `password`, `salt`, `origin`) VALUES (NULL, 'admin', 'Administrator', NULL, 'administrator@tablebricks.com', 'AQAAAAIAAYagAAAAECDOJwBpi0sqraVzpbiMs47xjH/gr8+/QcCClDnZ2oHzn1xA1jmU50ym+jODGjAHiQ==', '5Vjt5j4785', 'local');
# 1 records

#
# Dumping data for table 'user_permissions'
#

INSERT INTO `erp`.`user_permissions` (`user_id`, `permission_id`) VALUES (1, 1);
INSERT INTO `erp`.`user_permissions` (`user_id`, `permission_id`) VALUES (1, 2);
INSERT INTO `erp`.`user_permissions` (`user_id`, `permission_id`) VALUES (1, 3);
INSERT INTO `erp`.`user_permissions` (`user_id`, `permission_id`) VALUES (1, 4);
INSERT INTO `erp`.`user_permissions` (`user_id`, `permission_id`) VALUES (1, 5);
INSERT INTO `erp`.`user_permissions` (`user_id`, `permission_id`) VALUES (1, 6);
INSERT INTO `erp`.`user_permissions` (`user_id`, `permission_id`) VALUES (1, 7);
INSERT INTO `erp`.`user_permissions` (`user_id`, `permission_id`) VALUES (1, 8);
INSERT INTO `erp`.`user_permissions` (`user_id`, `permission_id`) VALUES (1, 9);
INSERT INTO `erp`.`user_permissions` (`user_id`, `permission_id`) VALUES (1, 10);
INSERT INTO `erp`.`user_permissions` (`user_id`, `permission_id`) VALUES (1, 11);
INSERT INTO `erp`.`user_permissions` (`user_id`, `permission_id`) VALUES (1, 12);
INSERT INTO `erp`.`user_permissions` (`user_id`, `permission_id`) VALUES (1, 13);
INSERT INTO `erp`.`user_permissions` (`user_id`, `permission_id`) VALUES (1, 14);
INSERT INTO `erp`.`user_permissions` (`user_id`, `permission_id`) VALUES (1, 15);
INSERT INTO `erp`.`user_permissions` (`user_id`, `permission_id`) VALUES (1, 16);
INSERT INTO `erp`.`user_permissions` (`user_id`, `permission_id`) VALUES (1, 17);
INSERT INTO `erp`.`user_permissions` (`user_id`, `permission_id`) VALUES (1, 18);
INSERT INTO `erp`.`user_permissions` (`user_id`, `permission_id`) VALUES (1, 19);
INSERT INTO `erp`.`user_permissions` (`user_id`, `permission_id`) VALUES (1, 20);
INSERT INTO `erp`.`user_permissions` (`user_id`, `permission_id`) VALUES (1, 21);
# 21 records

#
# Optional: Adds Sample data
#
#------------------------------------------------------------------
#

#
# Dumping data for table 'articles'
#

INSERT INTO `erp`.`articles` (`article_id`, `article_number`, `name`, `description`, `weight`, `length`, `purchase_price`, `selling_price`, `inclusion_date`) VALUES (1, '10902143', 'DC-15A Blastergewehr', '', 15, 10, 1, 2, '2023-05-23 14:30:00');
INSERT INTO `erp`.`articles` (`article_id`, `article_number`, `name`, `description`, `weight`, `length`, `purchase_price`, `selling_price`, `inclusion_date`) VALUES (2, '10902144', 'DC-15S Blasterkarabiner', '', 20, 10, 1, 2, '2023-05-23 14:30:00');
INSERT INTO `erp`.`articles` (`article_id`, `article_number`, `name`, `description`, `weight`, `length`, `purchase_price`, `selling_price`, `inclusion_date`) VALUES (3, '10902145', 'DC-15X Scharfschützengewehr', '', 17, 10, 1, 2, '2023-05-23 14:30:00');
INSERT INTO `erp`.`articles` (`article_id`, `article_number`, `name`, `description`, `weight`, `length`, `purchase_price`, `selling_price`, `inclusion_date`) VALUES (4, '10902146', 'DC-17 Handblaster', '', 11, 10, 1, 2, '2023-05-23 14:30:00');
INSERT INTO `erp`.`articles` (`article_id`, `article_number`, `name`, `description`, `weight`, `length`, `purchase_price`, `selling_price`, `inclusion_date`) VALUES (5, '10902147', 'Z-6 Rotationsblaster', '', 26, 10, 3, 5, '2023-05-23 14:30:00');
INSERT INTO `erp`.`articles` (`article_id`, `article_number`, `name`, `description`, `weight`, `length`, `purchase_price`, `selling_price`, `inclusion_date`) VALUES (6, '10901010', 'E-5 Blaster', '', 18, 10, 1, 2, '2023-05-23 14:30:00');
INSERT INTO `erp`.`articles` (`article_id`, `article_number`, `name`, `description`, `weight`, `length`, `purchase_price`, `selling_price`, `inclusion_date`) VALUES (7, '10901011', 'E-5s-Scharfschützengewehr', '', 21, 10, 1, 2, '2023-05-23 14:30:00');
INSERT INTO `erp`.`articles` (`article_id`, `article_number`, `name`, `description`, `weight`, `length`, `purchase_price`, `selling_price`, `inclusion_date`) VALUES (8, '10901012', 'SE-14 Handblaster', '', 12, 10, 1, 2, '2023-05-23 14:30:00');
INSERT INTO `erp`.`articles` (`article_id`, `article_number`, `name`, `description`, `weight`, `length`, `purchase_price`, `selling_price`, `inclusion_date`) VALUES (9, '1081019', 'E17D Scharfschützengewehr', '', 26, 10, 3, 4, '2023-05-23 14:30:00');
INSERT INTO `erp`.`articles` (`article_id`, `article_number`, `name`, `description`, `weight`, `length`, `purchase_price`, `selling_price`, `inclusion_date`) VALUES (10, '10801020', 'DL-44 Blasterpistole', '', 17, 10, 1, 2, '2023-05-23 14:30:00');
# 10 records

#
# Dumping data for table 'customers'
#

INSERT INTO `erp`.`customers` (`customer_id`, `customer_number`, `username`, `password`, `salt`, `origin`, `salutation`, `first_name`, `last_name`, `email`, `telefon`, `standard_payment_method`, `delivery_address_id`, `billing_address_id`, `registration_date`, `customer_status`, `comment`) VALUES (1, 1001, 'user1', 'password1', 'salt1', 'origin1', 1, 'John', 'Doe', 'john.doe@example.com', '123456789', 'payment1', 1, 1, '2023-05-23 14:30:00', 1, 'Comment 1');
INSERT INTO `erp`.`customers` (`customer_id`, `customer_number`, `username`, `password`, `salt`, `origin`, `salutation`, `first_name`, `last_name`, `email`, `telefon`, `standard_payment_method`, `delivery_address_id`, `billing_address_id`, `registration_date`, `customer_status`, `comment`) VALUES (2, 1002, 'user2', 'password2', 'salt2', 'origin2', 2, 'Jane', 'Smith', 'jane.smith@example.com', '987654321', 'payment2', 2, 2, '2023-05-23 14:30:00', 1, 'Comment 2');
INSERT INTO `erp`.`customers` (`customer_id`, `customer_number`, `username`, `password`, `salt`, `origin`, `salutation`, `first_name`, `last_name`, `email`, `telefon`, `standard_payment_method`, `delivery_address_id`, `billing_address_id`, `registration_date`, `customer_status`, `comment`) VALUES (3, 1003, 'user3', 'password3', 'salt3', 'origin3', 1, 'Michael', 'Johnson', 'michael.johnson@example.com', '456789123', 'payment3', 3, 3, '2023-05-23 14:30:00', 1, 'Comment 3');
INSERT INTO `erp`.`customers` (`customer_id`, `customer_number`, `username`, `password`, `salt`, `origin`, `salutation`, `first_name`, `last_name`, `email`, `telefon`, `standard_payment_method`, `delivery_address_id`, `billing_address_id`, `registration_date`, `customer_status`, `comment`) VALUES (4, 1004, 'user4', 'password4', 'salt4', 'origin4', 2, 'Emily', 'Davis', 'emily.davis@example.com', '321654987', 'payment4', 4, 4, '2023-05-23 14:30:00', 1, 'Comment 4');
INSERT INTO `erp`.`customers` (`customer_id`, `customer_number`, `username`, `password`, `salt`, `origin`, `salutation`, `first_name`, `last_name`, `email`, `telefon`, `standard_payment_method`, `delivery_address_id`, `billing_address_id`, `registration_date`, `customer_status`, `comment`) VALUES (5, 1005, 'user5', 'password5', 'salt5', 'origin5', 1, 'David', 'Wilson', 'david.wilson@example.com', '987123654', 'payment5', 5, 5, '2023-05-23 14:30:00', 1, 'Comment 5');
INSERT INTO `erp`.`customers` (`customer_id`, `customer_number`, `username`, `password`, `salt`, `origin`, `salutation`, `first_name`, `last_name`, `email`, `telefon`, `standard_payment_method`, `delivery_address_id`, `billing_address_id`, `registration_date`, `customer_status`, `comment`) VALUES (6, 1006, 'user6', 'password6', 'salt6', 'origin6', 2, 'Olivia', 'Brown', 'olivia.brown@example.com', '654321987', 'payment6', 6, 6, '2023-05-23 14:30:00', 1, 'Comment 6');
INSERT INTO `erp`.`customers` (`customer_id`, `customer_number`, `username`, `password`, `salt`, `origin`, `salutation`, `first_name`, `last_name`, `email`, `telefon`, `standard_payment_method`, `delivery_address_id`, `billing_address_id`, `registration_date`, `customer_status`, `comment`) VALUES (7, 1007, 'user7', 'password7', 'salt7', 'origin7', 1, 'Daniel', 'Miller', 'daniel.miller@example.com', '789456123', 'payment7', 7, 7, '2023-05-23 14:30:00', 1, 'Comment 7');
INSERT INTO `erp`.`customers` (`customer_id`, `customer_number`, `username`, `password`, `salt`, `origin`, `salutation`, `first_name`, `last_name`, `email`, `telefon`, `standard_payment_method`, `delivery_address_id`, `billing_address_id`, `registration_date`, `customer_status`, `comment`) VALUES (8, 1008, 'user8', 'password8', 'salt8', 'origin8', 2, 'Sophia', 'Taylor', 'sophia.taylor@example.com', '987123456', 'payment8', 8, 8, '2023-05-23 14:30:00', 1, 'Comment 8');
INSERT INTO `erp`.`customers` (`customer_id`, `customer_number`, `username`, `password`, `salt`, `origin`, `salutation`, `first_name`, `last_name`, `email`, `telefon`, `standard_payment_method`, `delivery_address_id`, `billing_address_id`, `registration_date`, `customer_status`, `comment`) VALUES (9, 1009, 'user9', 'password9', 'salt9', 'origin9', 1, 'Matthew', 'Anderson', 'matthew.anderson@example.com', '123987456', 'payment9', 9, 9, '2023-05-23 14:30:00', 1, 'Comment 9');
INSERT INTO `erp`.`customers` (`customer_id`, `customer_number`, `username`, `password`, `salt`, `origin`, `salutation`, `first_name`, `last_name`, `email`, `telefon`, `standard_payment_method`, `delivery_address_id`, `billing_address_id`, `registration_date`, `customer_status`, `comment`) VALUES (10, 1010, 'user10', 'password10', 'salt10', 'origin10', 2, 'Emma', 'Thomas', 'emma.thomas@example.com', '456123789', 'payment10', 10, 10, '2023-05-23 14:30:00', 1, 'Comment 10');
# 10 records

#
# Dumping data for table 'addresses'
#

INSERT INTO `erp`.`addresses` (`address_id`, `street`, `house_number`, `city`, `state`, `postal_code`, `country_id`) VALUES (1, 'Main Street', 123, 'City 1', 'State 1', '12345', 1);
INSERT INTO `erp`.`addresses` (`address_id`, `street`, `house_number`, `city`, `state`, `postal_code`, `country_id`) VALUES (2, 'Broadway', 456, 'City 2', 'State 2', '67890', 2);
INSERT INTO `erp`.`addresses` (`address_id`, `street`, `house_number`, `city`, `state`, `postal_code`, `country_id`) VALUES (3, 'Oak Avenue', 789, 'City 3', 'State 3', '54321', 3);
# 3 records

#
# Dumping data for table 'warehouses'
#

INSERT INTO `erp`.`warehouses` (`warehouse_id`, `name`, `number`, `address_id`) VALUES (1, 'Warehouse 1', 1, 1);
INSERT INTO `erp`.`warehouses` (`warehouse_id`, `name`, `number`, `address_id`) VALUES (2, 'Warehouse 2', 2, 2);
INSERT INTO `erp`.`warehouses` (`warehouse_id`, `name`, `number`, `address_id`) VALUES (3, 'Warehouse 3', 3, 3);
# 3 records

#
# Dumping data for table 'sections'
#

INSERT INTO `erp`.`sections` (`section_id`, `warehouse_id`, `name`, `number`, `sort_number`) VALUES (1, 1, 'Section 1-1', 1, 1);
INSERT INTO `erp`.`sections` (`section_id`, `warehouse_id`, `name`, `number`, `sort_number`) VALUES (2, 1, 'Section 1-2', 2, 2);
INSERT INTO `erp`.`sections` (`section_id`, `warehouse_id`, `name`, `number`, `sort_number`) VALUES (3, 1, 'Section 1-3', 3, 3);
INSERT INTO `erp`.`sections` (`section_id`, `warehouse_id`, `name`, `number`, `sort_number`) VALUES (4, 2, 'Section 2-1', 1, 1);
INSERT INTO `erp`.`sections` (`section_id`, `warehouse_id`, `name`, `number`, `sort_number`) VALUES (5, 2, 'Section 2-2', 2, 2);
INSERT INTO `erp`.`sections` (`section_id`, `warehouse_id`, `name`, `number`, `sort_number`) VALUES (6, 2, 'Section 2-3', 3, 3);
INSERT INTO `erp`.`sections` (`section_id`, `warehouse_id`, `name`, `number`, `sort_number`) VALUES (7, 3, 'Section 3-1', 1, 1);
INSERT INTO `erp`.`sections` (`section_id`, `warehouse_id`, `name`, `number`, `sort_number`) VALUES (8, 3, 'Section 3-2', 2, 2);
INSERT INTO `erp`.`sections` (`section_id`, `warehouse_id`, `name`, `number`, `sort_number`) VALUES (9, 3, 'Section 3-3', 3, 3);
# 9 records

#
# Dumping data for table 'rows'
#
INSERT INTO `erp`.`rows` (`row_id`, `warehouse_id`, `section_id`, `name`, `number`, `sort_number`) VALUES (1, 1, 1, 'Row B', 20, 1);
INSERT INTO `erp`.`rows` (`row_id`, `warehouse_id`, `section_id`, `name`, `number`, `sort_number`) VALUES (2, 1, 1, 'Row C', 30, 2);
INSERT INTO `erp`.`rows` (`row_id`, `warehouse_id`, `section_id`, `name`, `number`, `sort_number`) VALUES (3, 1, 1, 'Row D', 40, 3);
# 3 records

#
# Dumping data for table 'racks'
#
INSERT INTO `erp`.`racks` (`rack_id`, `warehouse_id`, `section_id`, `row_id`, `name`, `number`, `sort_number`) VALUES (1, 1, 1, 1, 'Rack 1', 1, 1);
INSERT INTO `erp`.`racks` (`rack_id`, `warehouse_id`, `section_id`, `row_id`, `name`, `number`, `sort_number`) VALUES (2, 1, 1, 1, 'Rack 2', 2, 2);
INSERT INTO `erp`.`racks` (`rack_id`, `warehouse_id`, `section_id`, `row_id`, `name`, `number`, `sort_number`) VALUES (3, 1, 1, 1, 'Rack 3', 3, 3);
INSERT INTO `erp`.`racks` (`rack_id`, `warehouse_id`, `section_id`, `row_id`, `name`, `number`, `sort_number`) VALUES (4, 1, 1, 2, 'Rack 1', 1, 1);
INSERT INTO `erp`.`racks` (`rack_id`, `warehouse_id`, `section_id`, `row_id`, `name`, `number`, `sort_number`) VALUES (5, 1, 1, 2, 'Rack 2', 2, 2);
INSERT INTO `erp`.`racks` (`rack_id`, `warehouse_id`, `section_id`, `row_id`, `name`, `number`, `sort_number`) VALUES (6, 1, 1, 2, 'Rack 3', 3, 3);
INSERT INTO `erp`.`racks` (`rack_id`, `warehouse_id`, `section_id`, `row_id`, `name`, `number`, `sort_number`) VALUES (7, 1, 1, 3, 'Rack 1', 1, 1);
INSERT INTO `erp`.`racks` (`rack_id`, `warehouse_id`, `section_id`, `row_id`, `name`, `number`, `sort_number`) VALUES (8, 1, 1, 3, 'Rack 2', 2, 2);
INSERT INTO `erp`.`racks` (`rack_id`, `warehouse_id`, `section_id`, `row_id`, `name`, `number`, `sort_number`) VALUES (9, 1, 1, 3, 'Rack 3', 3, 3);
# 9 records

#
# Dumping data for table 'compartments'
#
INSERT INTO `erp`.`compartments` (`compartment_id`, `warehouse_id`, `section_id`, `row_id`, `rack_id`, `name`, `number`, `sort_number`, `article_id`) VALUES (1, 1, 1, 1, 1, 'Storage 1', 1, 1, 1);
INSERT INTO `erp`.`compartments` (`compartment_id`, `warehouse_id`, `section_id`, `row_id`, `rack_id`, `name`, `number`, `sort_number`, `article_id`) VALUES (2, 1, 1, 1, 1, 'Storage 2', 2, 2, 2);
INSERT INTO `erp`.`compartments` (`compartment_id`, `warehouse_id`, `section_id`, `row_id`, `rack_id`, `name`, `number`, `sort_number`, `article_id`) VALUES (3, 1, 1, 1, 1, 'Storage 3', 3, 3, 3);
INSERT INTO `erp`.`compartments` (`compartment_id`, `warehouse_id`, `section_id`, `row_id`, `rack_id`, `name`, `number`, `sort_number`, `article_id`) VALUES (4, 1, 1, 1, 2, 'Storage 1', 1, 1, 4);
INSERT INTO `erp`.`compartments` (`compartment_id`, `warehouse_id`, `section_id`, `row_id`, `rack_id`, `name`, `number`, `sort_number`, `article_id`) VALUES (5, 1, 1, 1, 2, 'Storage 2', 2, 2, 5);
INSERT INTO `erp`.`compartments` (`compartment_id`, `warehouse_id`, `section_id`, `row_id`, `rack_id`, `name`, `number`, `sort_number`, `article_id`) VALUES (6, 1, 1, 1, 2, 'Storage 3', 3, 3, 6);
INSERT INTO `erp`.`compartments` (`compartment_id`, `warehouse_id`, `section_id`, `row_id`, `rack_id`, `name`, `number`, `sort_number`, `article_id`) VALUES (7, 1, 1, 1, 3, 'Storage 1', 1, 1, 7);
INSERT INTO `erp`.`compartments` (`compartment_id`, `warehouse_id`, `section_id`, `row_id`, `rack_id`, `name`, `number`, `sort_number`, `article_id`) VALUES (8, 1, 1, 1, 3, 'Storage 2', 2, 2, 8);
INSERT INTO `erp`.`compartments` (`compartment_id`, `warehouse_id`, `section_id`, `row_id`, `rack_id`, `name`, `number`, `sort_number`, `article_id`) VALUES (9, 1, 1, 1, 3, 'Storage 3', 3, 3, 9);
INSERT INTO `erp`.`compartments` (`compartment_id`, `warehouse_id`, `section_id`, `row_id`, `rack_id`, `name`, `number`, `sort_number`, `article_id`) VALUES (10, 1, 1, 2, 4, 'Storage 1', 1, 1, 1);
INSERT INTO `erp`.`compartments` (`compartment_id`, `warehouse_id`, `section_id`, `row_id`, `rack_id`, `name`, `number`, `sort_number`, `article_id`) VALUES (11, 1, 1, 2, 4, 'Storage 2', 2, 2, 2);
INSERT INTO `erp`.`compartments` (`compartment_id`, `warehouse_id`, `section_id`, `row_id`, `rack_id`, `name`, `number`, `sort_number`, `article_id`) VALUES (12, 1, 1, 2, 4, 'Storage 3', 3, 3, 3);
INSERT INTO `erp`.`compartments` (`compartment_id`, `warehouse_id`, `section_id`, `row_id`, `rack_id`, `name`, `number`, `sort_number`, `article_id`) VALUES (13, 1, 1, 2, 5, 'Storage 1', 1, 1, 4);
INSERT INTO `erp`.`compartments` (`compartment_id`, `warehouse_id`, `section_id`, `row_id`, `rack_id`, `name`, `number`, `sort_number`, `article_id`) VALUES (14, 1, 1, 2, 5, 'Storage 2', 2, 2, 5);
INSERT INTO `erp`.`compartments` (`compartment_id`, `warehouse_id`, `section_id`, `row_id`, `rack_id`, `name`, `number`, `sort_number`, `article_id`) VALUES (15, 1, 1, 2, 5, 'Storage 3', 3, 3, 6);
INSERT INTO `erp`.`compartments` (`compartment_id`, `warehouse_id`, `section_id`, `row_id`, `rack_id`, `name`, `number`, `sort_number`, `article_id`) VALUES (16, 1, 1, 2, 6, 'Storage 1', 1, 1, 7);
INSERT INTO `erp`.`compartments` (`compartment_id`, `warehouse_id`, `section_id`, `row_id`, `rack_id`, `name`, `number`, `sort_number`, `article_id`) VALUES (17, 1, 1, 2, 6, 'Storage 2', 2, 2, 8);
INSERT INTO `erp`.`compartments` (`compartment_id`, `warehouse_id`, `section_id`, `row_id`, `rack_id`, `name`, `number`, `sort_number`, `article_id`) VALUES (18, 1, 1, 2, 6, 'Storage 3', 3, 3, 9);
INSERT INTO `erp`.`compartments` (`compartment_id`, `warehouse_id`, `section_id`, `row_id`, `rack_id`, `name`, `number`, `sort_number`, `article_id`) VALUES (19, 1, 1, 3, 7, 'Storage 1', 1, 1, 1);
INSERT INTO `erp`.`compartments` (`compartment_id`, `warehouse_id`, `section_id`, `row_id`, `rack_id`, `name`, `number`, `sort_number`, `article_id`) VALUES (20, 1, 1, 3, 7, 'Storage 2', 2, 2, 2);
INSERT INTO `erp`.`compartments` (`compartment_id`, `warehouse_id`, `section_id`, `row_id`, `rack_id`, `name`, `number`, `sort_number`, `article_id`) VALUES (21, 1, 1, 3, 7, 'Storage 3', 3, 3, 3);
INSERT INTO `erp`.`compartments` (`compartment_id`, `warehouse_id`, `section_id`, `row_id`, `rack_id`, `name`, `number`, `sort_number`, `article_id`) VALUES (22, 1, 1, 3, 8, 'Storage 1', 1, 1, 4);
INSERT INTO `erp`.`compartments` (`compartment_id`, `warehouse_id`, `section_id`, `row_id`, `rack_id`, `name`, `number`, `sort_number`, `article_id`) VALUES (23, 1, 1, 3, 8, 'Storage 2', 2, 2, 5);
INSERT INTO `erp`.`compartments` (`compartment_id`, `warehouse_id`, `section_id`, `row_id`, `rack_id`, `name`, `number`, `sort_number`, `article_id`) VALUES (24, 1, 1, 3, 8, 'Storage 3', 3, 3, 6);
INSERT INTO `erp`.`compartments` (`compartment_id`, `warehouse_id`, `section_id`, `row_id`, `rack_id`, `name`, `number`, `sort_number`, `article_id`) VALUES (25, 1, 1, 3, 9, 'Storage 1', 1, 1, 7);
INSERT INTO `erp`.`compartments` (`compartment_id`, `warehouse_id`, `section_id`, `row_id`, `rack_id`, `name`, `number`, `sort_number`, `article_id`) VALUES (26, 1, 1, 3, 9, 'Storage 2', 2, 2, 8);
INSERT INTO `erp`.`compartments` (`compartment_id`, `warehouse_id`, `section_id`, `row_id`, `rack_id`, `name`, `number`, `sort_number`, `article_id`) VALUES (27, 1, 1, 3, 9, 'Storage 3', 3, 3, 9);
# 27 records

SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;