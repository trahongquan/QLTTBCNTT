/****** Script for SelectTopNRows command from SSMS  ******/
insert into [QLTTBCNTT].[dbo].[DM_ThietBi] (idLoaiTB,TenTB,Seri,MAC,CoreCPU,RAM,HardDisk,Monitor,idQuannhan,idDonvi) values
   /***(1,N'Máy chủ 45DE', '21569855', N'55:G5:IO:09:OP', N'Core i7 12800HF', N'4GB',N'512GB',N'',19,6),
   (1, N'Máy chủ Dell PowerEdge 1', 'A1B2C3D4', '55:G5:IO:09:OP', 'Core i9-10900K', '16GB', '1TB', N'Dell 27inch', 10, 3);***/
   
(2, N'Thiết bị mạng Cisco 1', 'E5F6G7H8', 'A1:B2:C3:D4:E5', '', '8GB', '', N'', 5, 2),

(3, N'Thiết bị bảo đảm kỹ thuật 1', 'I9J0K1L2', 'B1:C2:D3:E4:F5', '', '8GB', '500GB', N'', 17, 7),

(4, N'Máy tính để bàn HP 1', 'M3N4O5P6', 'C1:D2:E3:F4:G5', 'Core i7-11700', '8GB', '1TB', N'HP 23inch', 25, 9),

(5, N'Máy tính xách tay Lenovo 1', 'Q7R8S9T0', 'D1:E2:F3:G4:H5', 'Core i5-11300H', '16GB', '512GB', N'', 13, 4),

(6, N'Thiết bị khác 1', 'U1V2W3X4', 'E1:F2:G3:H4:I5', '', '4GB', '256GB', N'', 31, 8),

(1, N'Máy chủ Dell PowerEdge 2', 'Y5Z6A7B8', 'F1:G2:H3:I4:J5', 'Core i9-9900K', '32GB', '2TB', N'Dell 24inch', 42, 11),

(2, N'Thiết bị mạng Cisco 2', 'C5D6E7F8', 'K1:L2:M3:N4:O5', '', '16GB', '', N'', 8, 5),

(3, N'Thiết bị bảo đảm kỹ thuật 2', 'P9Q0R1S2', 'P1:Q2:R3:S4:T5', '', '8GB', '1TB', N'', 23, 6),

(4, N'Máy tính để bàn HP 2', 'U3V4W5X6', 'U1:V2:W3:X4:Y5', 'Core i5-10400F', '8GB', '512GB', N'HP 21inch', 16, 1),

(5, N'Máy tính xách tay Lenovo 2', 'A6B7C8D9', 'Z1:A2:B3:C4:D5', 'Core i7-1165G7', '16GB', '1TB', N'', 35, 12),

(6, N'Thiết bị khác 2', 'E6F7G8H9', 'E1:F2:G3:H4:I5', '', '4GB', '256GB', N'', 19, 10),

(1, N'Máy chủ Dell PowerEdge 3', 'I0J1K2L3', 'J1:K2:L3:M4:N5', 'Core i7-10700K', '64GB', '4TB', N'Dell 27inch', 30, 2),

(2, N'Thiết bị mạng Cisco 3', 'M4N5O6P7', 'O1:P2:Q3:R4:S5', '', '8GB', '', N'', 7, 9),

(3, N'Thiết bị bảo đảm kỹ thuật 3', 'Q2R3S4T5', 'T1:U2:V3:W4:X5', '', '16GB', '2TB', N'', 14, 3),

(4, N'Máy tính để bàn HP 3', 'U4V5W6X7', 'Y1:Z2:A3:B4:C5', 'Core i9-11900K', '32GB', '2TB', N'HP 23inch', 21, 6),

(5, N'Máy tính xách tay Lenovo 3', 'D0E1F2G3H4', 'D1:E2:F3:G4:H5', 'Core i5-1135G7', '8GB', '512GB', N'', 48, 8),

(6, N'Thiết bị khác 3', 'I0J1K2L3', 'I1:J2:K3:L4:M5', '', '4GB', '256GB', N'', 28, 5),

(1, N'Máy chủ Dell PowerEdge 4', 'M4N5O6P7', 'N1:O2:P3:Q4:R5', 'Core i9-10850K', '16GB', '1TB', N'Dell 24inch', 9, 4),

(2, N'Thiết bị mạng Cisco 4', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', '', '8GB', '', N'', 6, 10),

(3, N'Thiết bị bảo đảm kỹ thuật 4', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', '', '16GB', '1TB', N'', 24, 7),

(4, N'Máy tính để bàn HP 4', 'D0E1F2G3H4', 'C1:D2:E3:F4:G5', 'Core i7-9700K', '8GB', '512GB', N'HP 21inch', 15, 11),

(5, N'Máy tính xách tay Lenovo 4', 'I0J1K2L3', 'H1:I2:J3:K4:L5', 'Core i5-10210U', '8GB', '256GB', N'', 32, 3),

(6, N'Thiết bị khác 4', 'M4N5O6P7', 'N1:O2:P3:Q4:R5', '', '4GB', '256GB', N'', 27, 1),

(1, N'Máy chủ Dell PowerEdge 5', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', 'Core i7-10700F', '32GB', '2TB', N'Dell 27inch', 13, 5),

(2, N'Thiết bị mạng Cisco 5', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', '', '8GB', '', N'', 3, 12),

(3, N'Thiết bị bảo đảm kỹ thuật 5', 'D0E1F2G3H4', 'H1:I2:J3:K4:L5', '', '16GB', '2TB', N'', 18, 2),

(4, N'Máy tính để bàn HP 5', 'M4N5O6P7', 'O1:P2:Q3:R4:S5', 'Core i9-9900KF', '32GB', '1TB', N'HP 23inch', 22, 7),

(5, N'Máy tính xách tay Lenovo 5', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', 'Core i7-1165G7', '16GB', '512GB', N'', 37, 9),

(6, N'Thiết bị khác 5', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', '', '4GB', '256GB', N'', 10, 4),

(1, N'Máy chủ Dell PowerEdge 6', 'D0E1F2G3H4', 'H1:I2:J3:K4:L5', 'Core i7-9700KF', '16GB', '1TB', N'Dell 24inch', 36, 8),

(2, N'Thiết bị mạng Cisco 6', 'M4N5O6P7', 'O1:P2:Q3:R4:S5', '', '8GB', '', N'', 20, 6),

(3, N'Thiết bị bảo đảm kỹ thuật 6', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', '', '16GB', '500GB', N'', 4, 3),

(4, N'Máy tính để bàn HP 6', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', 'Core i5-10400', '8GB', '256GB', N'HP 21inch', 33, 10),

(5, N'Máy tính xách tay Lenovo 6', 'D0E1F2G3H4', 'H1:I2:J3:K4:L5', 'Core i5-11300H', '8GB', '512GB', N'', 29, 1),

(6, N'Thiết bị khác 6', 'M4N5O6P7', 'O1:P2:Q3:R4:S5', '', '4GB', '256GB', N'', 26, 11),

(1, N'Máy chủ Dell PowerEdge 7', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', 'Core i7-11700KF', '32GB', '2TB', N'Dell 27inch', 17, 9),

(2, N'Thiết bị mạng Cisco 7', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', '', '8GB', '', N'', 2, 3),

(3, N'Thiết bị bảo đảm kỹ thuật 7', 'D0E1F2G3H4', 'H1:I2:J3:K4:L5', '', '16GB', '1TB', N'', 26, 12),

(4, N'Máy tính để bàn HP 7', 'M4N5O6P7', 'O1:P2:Q3:R4:S5', 'Core i9-10850KF', '16GB', '1TB', N'HP 23inch', 34, 2),

(5, N'Máy tính xách tay Lenovo 7', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', 'Core i7-1165G7', '8GB', '256GB', N'', 1, 7),

(6, N'Thiết bị khác 7', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', '', '4GB', '256GB', N'', 9, 5),

(1, N'Máy chủ Dell PowerEdge 8', 'D0E1F2G3H4', 'H1:I2:J3:K4:L5', 'Core i7-9700', '32GB', '1TB', N'Dell 24inch', 38, 6),

(2, N'Thiết bị mạng Cisco 8', 'M4N5O6P7', 'O1:P2:Q3:R4:S5', '', '8GB', '', N'', 15, 11),

(3, N'Thiết bị bảo đảm kỹ thuật 8', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', '', '16GB', '500GB', N'', 31, 4),

(4, N'Máy tính để bàn HP 8', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', 'Core i5-10400F', '8GB', '256GB', N'HP 21inch', 8, 8),

(5, N'Máy tính xách tay Lenovo 8', 'D0E1F2G3H4', 'H1:I2:J3:K4:L5', 'Core i5-1135G7', '16GB', '512GB', N'', 35, 3),

(6, N'Thiết bị khác 8', 'M4N5O6P7', 'O1:P2:Q3:R4:S5', '', '4GB', '256GB', N'', 19, 9),

(1, N'Máy chủ Dell PowerEdge 9', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', 'Core i7-11700', '32GB', '2TB', N'Dell 27inch', 23, 5),

(2, N'Thiết bị mạng Cisco 9', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', '', '8GB', '', N'', 5, 2),

(3, N'Thiết bị bảo đảm kỹ thuật 9', 'D0E1F2G3H4', 'H1:I2:J3:K4:L5', '', '16GB', '1TB', N'', 32, 10),

(4, N'Máy tính để bàn HP 9', 'M4N5O6P7', 'O1:P2:Q3:R4:S5', 'Core i9-10900', '32GB', '2TB', N'HP 23inch', 7, 1),

(5, N'Máy tính xách tay Lenovo 9', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', 'Core i7-1165G7', '8GB', '256GB', N'', 33, 12),

(6, N'Thiết bị khác 9', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', '', '4GB', '256GB', N'', 14, 6),

(1, N'Máy chủ Dell PowerEdge 10', 'D0E1F2G3H4', 'H1:I2:J3:K4:L5', 'Core i7-9700K', '32GB', '1TB', N'Dell 24inch', 4, 3),

(2, N'Thiết bị mạng Cisco 10', 'M4N5O6P7', 'O1:P2:Q3:R4:S5', '', '8GB', '', N'', 19, 11),

(3, N'Thiết bị bảo đảm kỹ thuật 10', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', '', '16GB', '500GB', N'', 15, 10),

(4, N'Máy tính để bàn HP 10', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', 'Core i5-10400', '8GB', '256GB', N'HP 21inch', 9, 7),

(5, N'Máy tính xách tay Lenovo 10', 'D0E1F2G3H4', 'H1:I2:J3:K4:L5', 'Core i5-11300H', '8GB', '512GB', N'', 20, 2),

(6, N'Thiết bị khác 10', 'M4N5O6P7', 'O1:P2:Q3:R4:S5', '', '4GB', '256GB', N'', 27, 9),

(1, N'Máy chủ Dell PowerEdge 11', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', 'Core i7-11700KF', '32GB', '2TB', N'Dell 27inch', 2, 6),

(2, N'Thiết bị mạng Cisco 11', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', '', '8GB', '', N'', 28, 10),

(3, N'Thiết bị bảo đảm kỹ thuật 11', 'D0E1F2G3H4', 'H1:I2:J3:K4:L5', '', '16GB', '1TB', N'', 32, 3),

(4, N'Máy tính để bàn HP 11', 'M4N5O6P7', 'O1:P2:Q3:R4:S5', 'Core i9-9900KF', '32GB', '1TB', N'HP 23inch', 13, 5),

(5, N'Máy tính xách tay Lenovo 11', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', 'Core i7-1165G7', '16GB', '512GB', N'', 27, 1),

(6, N'Thiết bị khác 11', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', '', '4GB', '256GB', N'', 32, 7),

(1, N'Máy chủ Dell PowerEdge 12', 'D0E1F2G3H4', 'H1:I2:J3:K4:L5', 'Core i7-9700KF', '16GB', '1TB', N'Dell 24inch', 36, 8),

(2, N'Thiết bị mạng Cisco 12', 'M4N5O6P7', 'O1:P2:Q3:R4:S5', '', '8GB', '', N'', 21, 12),

(3, N'Thiết bị bảo đảm kỹ thuật 12', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', '', '16GB', '500GB', N'', 25, 2),

(4, N'Máy tính để bàn HP 12', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', 'Core i5-10400F', '8GB', '256GB', N'HP 21inch', 39, 6),

(5, N'Máy tính xách tay Lenovo 12', 'D0E1F2G3H4', 'H1:I2:J3:K4:L5', 'Core i5-1135G7', '16GB', '512GB', N'', 13, 11),

(6, N'Thiết bị khác 12', 'M4N5O6P7', 'O1:P2:Q3:R4:S5', '', '4GB', '256GB', N'', 30, 4),

(1, N'Máy chủ Dell PowerEdge 13', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', 'Core i7-11700', '32GB', '2TB', N'Dell 27inch', 10, 10),

(2, N'Thiết bị mạng Cisco 13', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', '', '8GB', '', N'', 16, 5),

(3, N'Thiết bị bảo đảm kỹ thuật 13', 'D0E1F2G3H4', 'H1:I2:J3:K4:L5', '', '16GB', '1TB', N'', 20, 3),

(4, N'Máy tính để bàn HP 13', 'M4N5O6P7', 'O1:P2:Q3:R4:S5', 'Core i9-10900', '32GB', '2TB', N'HP 23inch', 34, 12),

(5, N'Máy tính xách tay Lenovo 13', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', 'Core i7-1165G7', '16GB', '512GB', N'', 6, 7),

(6, N'Thiết bị khác 13', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', '', '4GB', '256GB', N'', 21, 1),

(1, N'Máy chủ Dell PowerEdge 14', 'D0E1F2G3H4', 'H1:I2:J3:K4:L5', 'Core i7-9700K', '16GB', '1TB', N'Dell 24inch', 8, 9),

(2, N'Thiết bị mạng Cisco 14', 'M4N5O6P7', 'O1:P2:Q3:R4:S5', '', '8GB', '', N'', 16, 4),

(3, N'Thiết bị bảo đảm kỹ thuật 14', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', '', '16GB', '500GB', N'', 19, 11),

(4, N'Máy tính để bàn HP 14', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', 'Core i5-10400', '8GB', '256GB', N'HP 21inch', 31, 2),

(5, N'Máy tính xách tay Lenovo 14', 'D0E1F2G3H4', 'H1:I2:J3:K4:L5', 'Core i5-11300H', '8GB', '512GB', N'', 16, 10),

(6, N'Thiết bị khác 14', 'M4N5O6P7', 'O1:P2:Q3:R4:S5', '', '4GB', '256GB', N'', 8, 5),

(1, N'Máy chủ Dell PowerEdge 15', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', 'Core i7-11700KF', '32GB', '2TB', N'Dell 27inch', 15, 1),

(2, N'Thiết bị mạng Cisco 15', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', '', '8GB', '', N'', 14, 6),

(3, N'Thiết bị bảo đảm kỹ thuật 15', 'D0E1F2G3H4', 'H1:I2:J3:K4:L5', '', '16GB', '1TB', N'', 29, 8),

(4, N'Máy tính để bàn HP 15', 'M4N5O6P7', 'O1:P2:Q3:R4:S5', 'Core i9-9900KF', '32GB', '1TB', N'HP 23inch', 1, 3),

(5, N'Máy tính xách tay Lenovo 15', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', 'Core i7-1165G7', '16GB', '512GB', N'', 10, 11),

(6, N'Thiết bị khác 15', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', '', '4GB', '256GB', N'', 25, 4),

(1, N'Máy chủ Dell PowerEdge 16', 'D0E1F2G3H4', 'H1:I2:J3:K4:L5', 'Core i7-9700KF', '16GB', '1TB', N'Dell 24inch', 26, 2),

(2, N'Thiết bị mạng Cisco 16', 'M4N5O6P7', 'O1:P2:Q3:R4:S5', '', '8GB', '', N'', 38, 12),

(3, N'Thiết bị bảo đảm kỹ thuật 16', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', '', '16GB', '500GB', N'', 14, 7),

(4, N'Máy tính để bàn HP 16', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', 'Core i5-10400F', '8GB', '256GB', N'HP 21inch', 36, 1),

(5, N'Máy tính xách tay Lenovo 16', 'D0E1F2G3H4', 'H1:I2:J3:K4:L5', 'Core i5-1135G7', '16GB', '512GB', N'', 31, 6),

(6, N'Thiết bị khác 16', 'M4N5O6P7', 'O1:P2:Q3:R4:S5', '', '4GB', '256GB', N'', 33, 9),

(1, N'Máy chủ Dell PowerEdge 17', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', 'Core i7-11700', '32GB', '2TB', N'Dell 27inch', 27, 7),

(2, N'Thiết bị mạng Cisco 17', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', '', '8GB', '', N'', 7, 8),

(3, N'Thiết bị bảo đảm kỹ thuật 17', 'D0E1F2G3H4', 'H1:I2:J3:K4:L5', '', '16GB', '1TB', N'', 18, 4),

(4, N'Máy tính để bàn HP 17', 'M4N5O6P7', 'O1:P2:Q3:R4:S5', 'Core i9-10900', '32GB', '2TB', N'HP 23inch', 9, 3),

(5, N'Máy tính xách tay Lenovo 17', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', 'Core i7-1165G7', '16GB', '512GB', N'', 24, 5),

(6, N'Thiết bị khác 17', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', '', '4GB', '256GB', N'', 13, 11),

(1, N'Máy chủ Dell PowerEdge 18', 'D0E1F2G3H4', 'H1:I2:J3:K4:L5', 'Core i7-9700K', '16GB', '1TB', N'Dell 24inch', 20, 10),

(2, N'Thiết bị mạng Cisco 18', 'M4N5O6P7', 'O1:P2:Q3:R4:S5', '', '8GB', '', N'', 19, 9),

(3, N'Thiết bị bảo đảm kỹ thuật 18', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', '', '16GB', '500GB', N'', 40, 6),

(4, N'Máy tính để bàn HP 18', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', 'Core i5-10400', '8GB', '256GB', N'HP 21inch', 7, 1),

(5, N'Máy tính xách tay Lenovo 18', 'D0E1F2G3H4', 'H1:I2:J3:K4:L5', 'Core i5-11300H', '8GB', '512GB', N'', 42, 7),

(6, N'Thiết bị khác 18', 'M4N5O6P7', 'O1:P2:Q3:R4:S5', '', '4GB', '256GB', N'', 26, 12),

(1, N'Máy chủ Dell PowerEdge 19', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', 'Core i7-11700KF', '32GB', '2TB', N'Dell 27inch', 14, 5),

(2, N'Thiết bị mạng Cisco 19', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', '', '8GB', '', N'', 17, 3),

(3, N'Thiết bị bảo đảm kỹ thuật 19', 'D0E1F2G3H4', 'H1:I2:J3:K4:L5', '', '16GB', '1TB', N'', 39, 8),

(4, N'Máy tính để bàn HP 19', 'M4N5O6P7', 'O1:P2:Q3:R4:S5', 'Core i9-9900KF', '32GB', '1TB', N'HP 23inch', 4, 9),

(5, N'Máy tính xách tay Lenovo 19', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', 'Core i7-1165G7', '16GB', '512GB', N'', 22, 2),

(6, N'Thiết bị khác 19', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', '', '4GB', '256GB', N'', 36, 4),

(1, N'Máy chủ Dell PowerEdge 20', 'D0E1F2G3H4', 'H1:I2:J3:K4:L5', 'Core i7-9700KF', '16GB', '1TB', N'Dell 24inch', 35, 6),

(2, N'Thiết bị mạng Cisco 20', 'M4N5O6P7', 'O1:P2:Q3:R4:S5', '', '8GB', '', N'', 2, 12),

(3, N'Thiết bị bảo đảm kỹ thuật 20', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', '', '16GB', '500GB', N'', 9, 10),

(4, N'Máy tính để bàn HP 20', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', 'Core i5-10400F', '8GB', '256GB', N'HP 21inch', 37, 11),

(5, N'Máy tính xách tay Lenovo 20', 'D0E1F2G3H4', 'H1:I2:J3:K4:L5', 'Core i5-1135G7', '16GB', '512GB', N'', 29, 7),

(6, N'Thiết bị khác 20', 'M4N5O6P7', 'O1:P2:Q3:R4:S5', '', '4GB', '256GB', N'', 31, 5),

(1, N'Máy chủ Dell PowerEdge 21', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', 'Core i7-11700', '32GB', '2TB', N'Dell 27inch', 5, 9),

(2, N'Thiết bị mạng Cisco 21', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', '', '8GB', '', N'', 1, 6),

(3, N'Thiết bị bảo đảm kỹ thuật 21', 'D0E1F2G3H4', 'H1:I2:J3:K4:L5', '', '16GB', '1TB', N'', 32, 3),

(4, N'Máy tính để bàn HP 21', 'M4N5O6P7', 'O1:P2:Q3:R4:S5', 'Core i9-10900', '32GB', '2TB', N'HP 23inch', 23, 8),

(5, N'Máy tính xách tay Lenovo 21', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', 'Core i7-1165G7', '16GB', '512GB', N'', 6, 2),

(6, N'Thiết bị khác 21', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', '', '4GB', '256GB', N'', 38, 10),

(1, N'Máy chủ Dell PowerEdge 22', 'D0E1F2G3H4', 'H1:I2:J3:K4:L5', 'Core i7-9700K', '16GB', '1TB', N'Dell 24inch', 55, 11),

(2, N'Thiết bị mạng Cisco 22', 'M4N5O6P7', 'O1:P2:Q3:R4:S5', '', '8GB', '', N'', 28, 9),

(3, N'Thiết bị bảo đảm kỹ thuật 22', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', '', '16GB', '500GB', N'', 31, 6),

(4, N'Máy tính để bàn HP 22', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', 'Core i5-10400', '8GB', '256GB', N'HP 21inch', 20, 1),

(5, N'Máy tính xách tay Lenovo 22', 'D0E1F2G3H4', 'H1:I2:J3:K4:L5', 'Core i5-11300H', '8GB', '512GB', N'', 2, 7),

(6, N'Thiết bị khác 22', 'M4N5O6P7', 'O1:P2:Q3:R4:S5', '', '4GB', '256GB', N'', 9, 3),

(1, N'Máy chủ Dell PowerEdge 23', 'Q2R3S4T5', 'S1:T2:U3:V4:W5', 'Core i7-11700KF', '32GB', '2TB', N'Dell 27inch', 24, 5),

(2, N'Thiết bị mạng Cisco 23', 'U4V5W6X7', 'X1:Y2:Z3:A4:B5', '', '8GB', '', N'', 8, 2);
