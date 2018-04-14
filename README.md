# ORMPerformance

Solution to compare ORM performances. NPOCO, EFCore,DAPPER and ADODBNET
The test example it's only to identify which ORM is the best solution to use in .net Core2.
This solution uses the "BenchMarkDonetNet V(0.10.14)" tool.

# First results
With this test I try to use query with some complexity, join, filters and orders.
eg: 
- Join 2 Tables
- Order by Foreing Key
- Filter by the join field id
- Top 100

## 10 Records in the database
 ![
](https://lh3.googleusercontent.com/tvCkwwSPpQtMZMJGN1gWB5hf7uZM82rf8gtfIwfGW5y4-EParMxB7iM4AvPa-2LWTHj_GXwml5cx4hBFry7vXtUwWAd_LpESni2uEKmwur9g2d1LzOYb0B5kbvRggCmZQt2fBYlSlkv2hxLIatruq-6XHoIOfB0POHDouFDCdg9WM2Yryihk_ZE4lzM0o9M7LtfQq5ICTFiUeqONAMBG5Bel3hPD_m9WOj6qmyHKsa5jIq40cdZXRkVVd9a8vqeIXeZk5_3ssF0ZdiqxUmiGUUAky-3OYhsu0RVe8GyrdIDR1U6sYirewm8VXD6DPREdzdnd5A9w3QmybSD-7vrDSFDnI49vr3F1xVCF3RAKwxkviQtWMGhS9RCzavsJCQfiTopmnqNgMtNZvMOG_bDSHmtbZKmrJs1LJyAwYGHxJ5I-vyf6dalS0HBCFUDfa2cwHtGUoP7TvlIu2iHb_eEHKIKqOz5hC_DKgx51ktCGL1S_EMZBDB3h0_oHNBtNR2blt7C_psYHHGQm57zZEbkaau-s4RXDgYQSz5wC4TMLuSLPVchcFjxwvX7HvdGGB3vfQ_DpUl4r0tl7ZUzzWzc6Pmp6e4vVY2F7NVh3T6ib=w770-h735-no "10")

## 1K Records in the database take the first 100
 ![
](https://lh3.googleusercontent.com/OShf9galBr0I0BjrNrwlCLE0V9ZUS8EI-KZOpaGywyfyPI3J2W9eDaNHqP2sqAmA3Ij9Wc_LtRmSyD6NsehgGDNlfgPiqoPe2SqsynrK4IqKm2H3q6eByYThHWojo0DfLXe9_xSRgQh80JJBb0txyENCg8y-ivL_b8Z5PJvjN8ACifpQijlqhZ1aINj2a4hIWD2RtEIbqe6NCNQrtTN2GZ3c2iKptB0IGBzhG2-U9OHtxuNTx69W8ZOYFYtmikNV9KrHgs1SyTI3gFwva9tAjJ8TK1Q7itJJ8xeYhUCllWH6yVCHDDLnNjsyDBrwKdZ3WtBK_jH3J3e59x_heIbKwBdLHczI1M3RWNWrFh7nn3_Co8AcVA8djOucj-r8SFcFLmnCTf8bdLiFOt8NRYxCH_9v43IbMjFIzDmu6mfSUzYkfMiicUVCksFOkrdOLQGGhIwxgTv_9W5GGSneo0AqjsrrLE7GaXM0Luc7Z0_Ly5VW7H0X6gS9_SFft8ngKK3eMFq5HOg_7QP0Z0aVigKF7-ZwPnDtDE7MsFDJk6UNOee1QpBKmzdX5A8Lwn8cbgISX3CynR4mXoBRW58OUV13utskgtU6RORfRUdb8q6H=w792-h599-no "100")

## 1K Records in the database take the first 500
 ![
](https://lh3.googleusercontent.com/pVWzG4k0WyDmLQLv39iFg0GjHiHP6QexbwYKm34DY3JC7BCWEysVKARLIBer5rx6HBhFUSxbubkB98UkQ6qJZRZbrRpCLgPh5Sie1VCsk2N7zz8KORpSc-KktWvKi0Qbp1RrkweGuBab-dahh5ZHocYB7aveYpO01iDoKie9-QaaCrVhv47i4GJi-GSjb7qhIuAxPs88XNkXMsBN9q7E6UoVMRzslbphy67SL-6jdpbFlKr337XU6YsmXZ3lGN72FoaWJAGvGJm3OHvHNb-zDfnvJ3ZFgqJX5h7_inCCfn6nX4nTA8qio52J2DCFwUVuBWYK6zvvF5vpufCfbMJx5KYQ6shVEJlM3CgiGbdQ8Sw33RGsmAPNF7zmIdYzgBm-O1gXNrGXtyeWG0ZYdqzHXClcH9UppaNQMNzVywxbDPX4EGPI27rSVDWoz5kKD0bZhhNjKU4QrxVMTBR_6hKUQogAucAGx6eiB1ZJFwQTIqwjhNRCjI1S7OVa9zypu1C89WPXqIIAmnID1LK16xfeYJJZ9Wfcqraaz-ImInsRO7pOc5TBdhxTo5-JnyO9aftV5j52m3ZkwJU_t4RdmCWxDwbL_dksLgi6xA-RnVG_=w776-h628-no "500")

## 1K Records in the database take the first 1K
 ![
](https://lh3.googleusercontent.com/f4Sh_Jr3GGyideaSwxRt4vta8OD1-phXHZDGUtUaskkado-LoUYe62nUwE1zn6icyI0kulBgpbdP8-wrEaGnXul8RXxVjoFGA3I88a4Yd7aCAeaxoGiDluceGkY5e2Wu1OhIIWGY2lRi5J1tEnvQSzSAzGet5EQ7R92K_VD4SyUD5mIRiDm1LUzf8VvkT14I4sVF5Arjy93n0A57NQLRYx0gI09F7LnHvtjj3qi99g6v7wrmb5QI0EB-pp7oSSVpsTNgtL2xYUtj_x9Ng8zCFkpUHkLP1Og_vPygOKA82d0_JgQoSrKBWOYXyM7MGAR1LGyWvawlQ0R6kK6OmgAkpLUP4M2njDmQaYiGpPwsuo8xyqOUI3aZV__lPzl7Gc9Rr9txUMkItCzMzA6lArRkv-QFWoZ3wR9oLqWcvT9noz7JoOgwir5NVlrzjwVwOyJc8xnTEXSmWyeTkM1hnl03T71Mg4StBE8nwnuDW75i2LIECOB0K-5ctJO_fespSKHF5fR-mMrd4iJy2h6wIZKtp72eCms9aJwdKfWKndN-n8ryKnIYhopi5FiPSQ7hK9s-dLbPNCna8nsMVx_RrnHzsmgiF_JoZNHDsr2RoJYn=w781-h618-no "500")

## 5KRecords in the database take the first 100
 ![
](https://lh3.googleusercontent.com/3spA-1CRJXtPzJu65dJFvZUShCfOVJuEbceLc-y8i3KEGRnFp6hRP8mH4dd9Ag4FHNoNfYACxFbTPd2kjFiq-EVsMn305JATE2qS-SacnzASh4nThNiqMKoLS5yq1YNKOWWZnaCUiuwlpdsxrw8yQCgfJcMQBozEOD4cTfYoSl_KVtvB5rpm3rliK-uwa9sGbahe9_Cgv_24yWdL3MVquMc6xmInm8JYUth6sLA2suahgkiEn1YOrh3vONpY6ts0xBj14x1bfZ6c8eNujDpnLwIIvKfJN49SB4w3mEimITlf46wWFhvcbLbZZN3uSKtkkDFkUtKCGQFWZGMxDNB9wvoaA_tRj9rEhYRl00f7deTp3uRo09Py6TqPqqTfjcuFZvyr5QOajAUZ9ZUMJd5Xs7Xcd9iBGjA1RQdbAoquBxKAljq7hXrXFOqJVg_tKzP6a75XqJdAm11--UV5e2ICGU-4gpL8nupBAa9L8llgrmnIVEcm6QM6QwP3SC_axfEg3LautJvQgt9v1h3mcpSoBoNR2dfkwY9FzRXRLJNIgP9MOl8bUv4WPaGt1l_Kk1wK7xY_ZwoV0obH80Mztdkc1mBJ57ggPB2ywUxU8r5M=w808-h599-no "100")

## 5K Records in the database take the first 500
 ![
](https://lh3.googleusercontent.com/bf569CsZxLJiBjWY9OxaT3DO4gTdySCnoz097BE14_YN9IORrGzk7PGfoZkrEhhF1djI9neZH155AuXIfgaZcQgrD8AXNYv3n-p8y1CzDNPdyYYkeiyaEZgm7Yko6JNc5OlcVEvknbb94UBl5hw__Xk-JU9NwN-Y6J1WGUIeKz_u6f9orSNwdNKwGlnhEq4g9RY_yf8P9-GGnqKH8dIfpeFtCaEecPH1cQqx80bTzKWZ4NJpJYurLsQ0n2f8_PLDC6wvH02iBhk4kcEdrh_RLBt_2WRgVC1w9RRjrlBe3Y8jel73aFTSpcegl01oAARFZ19LVUEcVt3LXS01BjNtu98VW26ONDZRt-2VThOpyiEC5pqZUw0KbhmdqfCYOmJ3bXORnz77rdOzi3-2OdD1K16QKleKxFNUa6q0einQhcGDMuzYPcFlddwsjn-LJrGHZJwEgPGKHfQ_RJUbCEDB8pBYTjOpoNfPBIF7ft7DhadcAMWDrFTVl9Vj9ggumCjoVjs5r7tjhRutni7IXIahpN8PsEQnd5pjTN_WjIiAtvmlr_00AlvBSBEi-s7mV6BmotS_-c5leD0hwDV--i1c9G6Tc62Y9DXaCvXspxT6=w803-h628-no "500")

## 5K Records in the database take the first 1K
 ![
](https://lh3.googleusercontent.com/rPeCbOdHaJU-IlPMH7jdiGSre2JLRN74hf8YvuZynMSwAZyqnUyqAGVy5ZOj4F9gA4EgR05z_bNoh4ROjwO_prQe4zswkOoNMoBOljbQryhVlCL03oBcIsvBKuofW2M-l80joIhhZk58oKhOiLV6VvmTRnuFsjo31P_PwIpPKl3_MZrvImwseZ8xBYj9ZHUEPsb7vUFA-0m-qhSrIvzNK7S8VUiudSXVQcW06_0vXaQll-X0tE-20R0v5PzMLqtB8DYzFj_xq_IAio-J8AlIoi3k3WOudWOzyTCKwuzF5SET4Offuek1Ud8YXcU8LK5NHb-DaBglfC34HmnjakWMuOcthhWUtcCM4HXou8-MLNH5d7N715sO3rlCQ3jJ9oHdbi5ZWmPmPxB184hC2y9Mg7Gf6h4F5Oj0eVa-CMkl5mEHR36un-ABFIjaDw7RGgyUcxgW0lSuATXtBHfZdA2zDScWEPWvsLbwZL1qg4ohUb3mSaeOzdbCFsY54xj5HsyoTTpD5ctPUhykofLeHorQHMnD9TShdwyACzsdpgFKyE4Dm124gJVEHp8g2dDSetgi1nh-ZuSCkojPLESMFZ3nOmW5f5N2-H1pXhCp1kB0=w814-h615-no "1000")


## 10K Records in the database take the first 100
 ![
](https://lh3.googleusercontent.com/a3SPzn1D632-JnfrAZeaFjQ4JF-mjiUVCvs62w4c0_pgdhfihyQfVefTwdByj2dadvdDbKeLYCnpdGMpQ1eVWgQK0MedQk53yPO4yg2fEA6hi6YMHy7N34XtvwK47m5jB6qE9YK2-uWRJdE05aAXHMukGsw4RtxBym4HbVxqJWhz2f4BZP7e8jgW18hDFrJGal-0ykcBIuHN4g_GjZcr7Fj9neHfkeszJywMGNLdLWWwvFFJ78Eehms7XVoG8SY0ErcxJGqfocvZV2i2tR3BerJynJdlWQ8--xvxVt7BK5UdGwavR7kCAjxiFa_qpgPpEab1lGk-RsydmL_ybC-LYMLlrXTaiGHwnjeXb_rzm4d5VCy2lXu6N-OzoqSqEOkNyFM-NRpFiU9YyXdhhvBXsusITHSN-kMsqdNVX7quaWkTUpZoTC-OZcRBTWSQyc3aX1I346Jwkn5qbCIxsau8XrYQmpQ6a3w5nV__ETbJEJ-e8uT1J99q6VWY-B9tWasCvRR6R9fwmK1rHbRtmmZYgv58u-FkZS2CZJkguPPk1_n2PgkUrZKAppPKBkM2BH4VEQSwFaj9bVcnVt6a2annQHHm8xiOdoglqbaBwHwK=w801-h616-no "100")

## 10K Records in the database take the first 500
 ![
](https://lh3.googleusercontent.com/e2XVdXT66xW7YVAj9x1NRigl2hK0TLFlBV30v1oLAeWQA2hdVSC6I-utTE8nAZil0i15Z2MShuA0HhOrt0v35BVF2YZ73MHZnLZRAaEBCJ2WqDZNASBFLGjxfO-O6byGYO1_VNcvlL26JTM82b_YVq6RfZzcyBbQowTzVUGuDWMKiyk5njbQ2UYUuuu3zw7bYKtbIJH_FT2yHIOelmhptdWP7PZnkFRFIpvv4e4eKKDLgzepSPmTiR9U3O0kQipchJTjVwZAgWapYXJDBNQoahWsrJ5M1lBgLvdIiyayaQ8_tZ_Xnyw5KWU6r4MZEeVnWH2jfUtM_D1Je0HS7LwJZozxnuFY6Z_oi3lo2CSDOuawgMG4sXcPzE39vqvyzY9_g49Rr69u43Rq-1-jyD__4aQPYtrhd3R1oY5jCOlJpA3vQNR_9Fd3Q_lxE9mmNMcn46JJwcF-ES_dG1iheRC9iYoZrh5hh9aS9UPh_AVon22_Rg1qBjuNKKEwlIjXmM3b6SoEXTmAH8quxumnv7bMMctkQqrVRnR6Kty0iE_8CaBG-sthJHvI-513AAw6MIQisWwQ3IT0y6NiafmBaBpJQnSBlaypxp95K2CNWHgP=w797-h626-no "500")

## 10K Records in the database take the first 1K
 ![
](https://lh3.googleusercontent.com/qox5OEf33uK-Qp80O23OtUQG6k-zPhEXHISVjs_cvM_5vaj4ThNKlDVbGpYZa3ER9NntRolh2QlDmqg27fP6kgUxg6d-RIIMFCCbbS0pBh7y7H2WK3gpLxwdPL_rQSNLOjA3udpU5tsgSJNBs8ZrVysHillOOjlc--nvHyURvoouiX4hFIW1znvfKDOQEa4mLAAJToNlzfx47i4ROkKBUkjMWxsDrqhiMUG8xodu-IVmWAAq5ut-JLvqcnw9dF7agw1n9B4mGZfN4tZ_qFlwyMQ_a1Gbye0De7eZZb4pqTYAEP0aAKJJMbKYApeihfZDgAvFt_h4vgfgNZuD4lYJ-Iwjjyz_1yYHIGWvHQyvpufGlADlGdaXkfjCLMbVTLLB8upLFokWLwqJqFmB0ZjBtUH34u7pktBxuAqZ95V8RuUjmr_i926NO_0gVb6GnQTIlpl9REr2n3gPLJsAP79hIC7UtP_M6QuKHNqbe36q7ki0_T83nNPJjUu0Nj4a-WCrDcjoc0LrEQAsw2CEVhcPlKCTIMY86VPCIjjUvc6RZBInulfLzioWf4FdNk-H9R_2P5GdCFZqPoS4inwKPtCYdNgF486f0-Y5XI51gjAV=w815-h673-no "1000")


## 50K Records in the database take the first 100
![](https://lh3.googleusercontent.com/9uPhjLBQEblRvHXXorJE56mxWOKN-aVYDpqU6CM0DYlFlapQ6tNq_Dqdc-wEdMghdy1GeMMEL8KjGgSctlUpmyBpOog93vh45QFp1eB58gHUai0UpKnX-GfcHo7Mat15gcc2akHc3mlgmmMUCmSrGEihCf3Pvkbb5OhlLocnUQvvDkqDHMGoWbL9ROjhXEC-ktSJRbKBID1HWwa5HothPH7iMPjo6-5m3KeTYdWgpGNzTBmZyBgJg8SsM8BMdrWawmypgiX1Dq-zwmNEblTxZJv2FBkAfNVAkceuibgFM1GJ_PL1DaZbkAeamCiPgo6cx1AyND3VB5w7t4u8Av3m4y5ggqf2rvtuFO9it8M2sPIubT7cPSBk9dbAoPmQM4BCA1iA6gfPFzkD_KntiL-hj2CcdXy6ZLn5u_Bq75Cqnor6y6xAcG8b1T_Mh6MX6mzOUxGvLQ_GDmwtS90TczB86b0ClfS2xrjWQN7kzIS2f3Wc2IrR4T5J7dkqD-UtiUJPVRdpsKQKwkYVgusWtaAF0QzQ48RBXezes5G_CviltVVlZkIpPqHaQIrdM6V_bnlFSGN4ifw9jhG4S01IXGchz-iFqJmNIPNreT0jTEwA=w785-h620-no "100")

## 50K Records in the database take the first 500
![](https://lh3.googleusercontent.com/VCXj6d6k0ni8ccNJ7-TeeviUnuIWJVVDaa25vxQiCyQ9sSTyTkGqUFs_YUFmpFdfWmQllmPPM4oKDlNPIggLJbkqPX9QpUPbJ5oltnDD5jZFPYdNs8aREAtEDdiFhzOulvxxxx470iEUEsUsvlxiwrh1nfrhW67FQJ_x0PBY9UUUIUwFH1Hq3si9hZUwusDTpqudLBzczu_D_BfjRSEovqTRBIKcHU8q7OzBOpbt9LODSqflCtY9-DFWUfAZjha2gi0K-MIKbFLJcvzO0kvsoDpYeGuwrfutG3St-5aJfkRAVeOOCHdc1rXYMMUi1DWDyKMVifVCfAnsharTQzO97YF3Ix3tqO1p8EZSxTdVQ9h38GvSnnHni_7gHrxhKUNkNAaED0eFb0qO3zAKK3WkaapqeleneP-dLmnyHK76FDIN5PufUh_FJablBUS8hUST26AQpt8NbBeIYV0rLPpvaOLIs2J4RviZqqw0keF3lSMcF6sPf_kIzp0C23HI1qMoiqIM7O-q_0gQCvTzwpzpH0vymu00E93Kn0SVT4cDSp9kH4Bx2l9ideDkXTP1ZRm3ZFvaDWuwoEavClwwdGGIsYgW8BYTl_jtVHOgu_wu=w765-h641-no "500")

## 50K Records in the database take the first 1K
![](https://lh3.googleusercontent.com/rgPHGM1Blknvi1L266AIIlomjfIe-_kNuad13JmHRtFX0sa8bAHX__cBfGeM1sgEONWUQlCnyHPRI1Hq9epG2C511qk6-p98FsbSziQIZLt-EKJgt7AOp8JXqyLD7Qk1mEnYlR2j24p5fnNlaaNJRZhQCEEVrm-orrP5gT8ZgnhdFC2l2Jk68pGM4bLLyT63RzSfbQrEckpHbT0oRS55Wy0JvoHv2qy6Rkz9LwXB4cGgu1v7RiJMysJ-oVerB6bLpYkXxDuEhg-DLvN_NbJA1mqwwQA4YPI7ChxfLs2RUTtw2xx2OlwbRfD5nQYGP_r5er2E0OFO7XPErFiRnAl59vw0eYB0VFlImnlmLd33tzul4_HSfneVS6AfyTEPII0rpjehNM95gJMaumw5NLmdL4ErFC3Y2tL8EdZHwxFxFRkm5iHzVHkbgFsryNfsTcdZjwfegKt5AxdVBzsTqHXZukPMbEnkb7iVogOe3OcWjoZpdeYPTsM0wCPR8DAo8Qp2_IG_fyj2iExJ6LLUVvyDSzLLK3XZo1MoR9E-bBEZfh9VS2PwXr7-JBIquT5f3cJUebXL05eQR3fjAQTQ-1bBw6lboqxsj_2Tgzybtefu=w812-h584-no "1000")


## 100K Records in the database take the first 100
![](https://lh3.googleusercontent.com/TVy8Zsd-OVyW5BiUYEY9hULyD8TK3mw7uVx9u2hcpVfEqH3fvMV7XwkYYd-Z7DnEpZmPRj4BM_Ok3kuRP8pT54nqzjnmxQVlLqhh9km4Vr922N_J8JEbBXNz7rnKGZSroEFwoiQChaZfhrZzFqhUS4cmPhxFM6LYhV9KcfQE64p81jxdjy63AWK6m7C1o2m2Hops8W1ASkj4V_znh8QlJ1xpGFkoDSIRaIcjIxq-NM_sy8tqoDMRK3nJRl5rqNmmx9ssVz6QE7olWdVqCdhIDcG3wo0G_o1FhyhfpFxBfpnuu3y6AYhWvcy-Lo5EAmvTlorothzAYhYokwWDOUDlfodkTKt_8U2FiBjvIbh6Z-4wuRl2x6CA4S8yDZ7XzPh25lHNCFKOxCOf99y9Co9mel5XkBTiZfiRSvFotKTV4lPhoOuCmfeV_i5g0Dh7jxGPoxehuZkTzLJEI0schNgW3uGNPVDf2oSLC6xMi33fpy6gZ8vvWNq80o6PtlWqDbPfgZJkpR6pmz1_cvkP7oSfbK2vj47McoH0XjRgln9TNmDFr7IRSZCJ5f-brJQUnF6c6py5khWFhJYVpsnDC8_vg_qs7cByjbZrurfpbTTB=w795-h621-no "100")

## 100K Records in the database take the first 500
![](https://lh3.googleusercontent.com/4l7_eCWnJzV11ZKxn1QMAiTogUZ24xz4wm48mh0wmAFnv5feMm9sNy9NNbPBDcdeTBbwuaDwMEDTOukrzh34o8NkXAbexjuvsqgxGOL_iLbhe2ikbMFbLZzcQfuiuFfKryR4s6K8YXjP9SuEbw4Pq4Gy_iesHokuKirYJINJvujrRa04sRVonXkJXlZosRAUF5kUN7WlyT5s4X8gpnJ1gWtkGyHVTbews3Y4vQogHGWX70HTgsyNV3lb-niNjHXt-ZUTfdxYAyOI9lY1OohU4DFMWG2HjTtYRJWoHq0il_rpD5kB36vKr0BGAzJrj-k4lTpFZPcFFfatTUJ5A-15nC6EAzWY66KJR-Nr1uvTFVyNfH-9EbYHMwHBi4q3U1J9VWvX3pfSoaEfYUmWuFn-NKIf30aitKtV7_Tn27Waaaet540IYNubLdUs5zVGmcF6Utr_Eu1dhqawfdykZ_0OXy3HDWm2ma_zY7y5kZ7ULCyGbbHTobBl3oTC2Jhs8Erh2B-QaaKRVfxSzaUYdXyJ08oana6f0-YOb4CmBLMC9S0XF840bXZch1tD5vdFidAdJ0E-N30wHBXd3f9FPzInmUHA6wDrKenusOG_KWi-=w797-h626-no "500")


## 100K Records in the database take the first 1K
![](https://lh3.googleusercontent.com/F2w5HWdivKm0WIXfeVjdH7MKGLR--dT1EGKmefIekCHeoziv7zDaZnSjy3_lkKcVXheImQwtdv4EOGQoVQcY8sGoGEw5XVG695v0UuOBILkUfjf9R0V68dB30dbncIVgbVpZLoqC_RE8W_Up2K1GZzOc9uREPdUgaj1GOPbk8ccHWDW-6tE0l8AwFG97pb10cm6cv0s52egQvRIC6njwAgl7ci5d1ao1SwJOmXV7ZqyMiToa6HJ3CsQfEMzzS5YHPOERkymhgw5jLLyPHIz3bVxNwpm4-SqlrIewq-vukw2vqCajXjwNHH-fFnUnFIPEBsK720bS1brQ4dAJuuXJIsmx4guC7hwplAMzxWv1Zg19-ZxV9S0k3muBqorYU-Y9V7UAVY3MyBF0JCq0d0J5JfR28Xqj0tXvsX5O49MjHL35JiR0NJRQ_079SZgtCdqN0qdP6RIIeXNOCLHwflIMLG58Fks69ZYmIz6qDYuOEUs6iHhSlQ1GYEA094SVodlVt6zCVZ53SeALq9UDz9G94KKfMuGzJnf1Mv5vu6TAXlxilwMWdQ35cd9_IA9k_oW1oW4Zaat_DqS2VcpiQCm5F2RcDwakIJN68-lcEeiQ=w988-h638-no "1000")

# Queries generated by each ORM
The is the result for each query mady by the ORM, to prove the same sql query results .

## ADODB

```css
SqlDataAdapter("SELECT Top 1000 CLH.Id, CLH.Description, CLH.CreatedDateTime, CLH.UpdatedDateTime, 
CLH.IsObsolete, CLH.ObsoletedDateTime, CLH.CheckTypeId, CLH.IsSystem, CLH.VehicleTypeId, 
CT.Id AS CT_Id,CT.CreatedDateTime AS CT_CreatedDateTime, CT.UpdatedDateTime AS CT_UpdatedDateTime, 
CT.Name AS CT_Name, CT.IsSystem AS CT_IsSystem 
from CheckListHeader CLH 
left join CheckType CT on CLH.CheckTypeId=Ct.Id 
where CheckTypeId=@ID order by VehicleTypeId asc",conn)
```


```css
exec  sp_executesql  N'SELECT Top 100 CLH.Id, CLH.Description, CLH.CreatedDateTime, 
CLH.UpdatedDateTime, CLH.IsObsolete, CLH.ObsoletedDateTime, CLH.CheckTypeId, CLH.IsSystem, 
CLH.VehicleTypeId, CT.Id AS CT_Id, CT.CreatedDateTime AS CT_CreatedDateTime, 
CT.UpdatedDateTime AS CT_UpdatedDateTime,CT.Name AS CT_Name, CT.IsSystem AS CT_IsSystem 
from CheckListHeader CLH left join CheckType CT on CLH.CheckTypeId=Ct.Id 
where CheckTypeId=@ID 
order by VehicleTypeId asc',N'@ID int',@ID=1
```

## [Dapper](https://github.com/StackExchange/Dapper) V(1.50.4)

```css
db.Query<CheckListHeaderADODB>(
$"SELECT Top 1000 CLH.Id, CLH.Description, CLH.CreatedDateTime, CLH.UpdatedDateTime, 
CLH.IsObsolete, CLH.ObsoletedDateTime, CLH.CheckTypeId, CLH.IsSystem, CLH.VehicleTypeId,
CT.Id AS CT_Id,CT.CreatedDateTime AS CT_CreatedDateTime, CT.UpdatedDateTime AS CT_UpdatedDateTime,
CT.Name AS CT_Name, CT.IsSystem AS CT_IsSystem 
from CheckListHeader CLH 
left join CheckType CT on CLH.CheckTypeId=Ct.Id 
where CheckTypeId={checkTypeId} order by VehicleTypeId asc")
.ToList()
```

```css
SELECT Top 100 CLH.Id, CLH.Description, CLH.CreatedDateTime, CLH.UpdatedDateTime, 
CLH.IsObsolete, CLH.ObsoletedDateTime,CLH.CheckTypeId, CLH.IsSystem, 
CLH.VehicleTypeId, CT.Id AS CT_Id, CT.CreatedDateTime AS CT_CreatedDateTime,
CT.UpdatedDateTime AS CT_UpdatedDateTime, CT.Name AS CT_Name, CT.IsSystem AS CT_IsSystem
from CheckListHeader CLH left join CheckType CT on CLH.CheckTypeId=Ct.Id  
where CheckTypeId=1 order by VehicleTypeId asc
```
## Entity Framework V(2.1.0-preview2-final)

```css
db.CheckListHeader
.Where(b => b.CheckTypeId == CheckTypeId)
.OrderBy(b => b.VehicleTypeId)
.Include(p => p.CheckType).Take(10);
```

```css
exec sp_executesql N'SELECT TOP(@__p_1) [b].[Id], [b].[CheckTypeId], [b].[CreatedDateTime],
[b].[Description], [b].[IsObsolete], [b].[IsSystem], [b].[UpdatedDateTime], [b].[VehicleTypeId], 
[b.CheckType].[Id], [b.CheckType].[CreatedDateTime], [b.CheckType].[IsSystem], 
[b.CheckType].[Name], [b.CheckType].[UpdatedDateTime]
FROM [CheckListHeader] AS [b]
INNER JOIN [CheckType] AS [b.CheckType] ON [b].[CheckTypeId] = [b.CheckType].[Id]
WHERE [b].[CheckTypeId] = @__CheckTypeId_0
ORDER BY [b].[VehicleTypeId]',N'@__p_1 int,@__CheckTypeId_0 int',@__p_1=100,@__CheckTypeId_0=1
```

## [NPOCO](https://github.com/schotime/NPoco/wiki) V(3.9.3)

```css
db.Query<CheckListHeader>()
.Include(m => m.CheckType)
.Where(m => m.CheckTypeId == CheckTypeId)
.OrderBy(m => m.VehicleTypeId)
.Limit(10);
```

```css
exec sp_executesql N'SELECT [CLH].[Description] as [Description], [CLH].[IsObsolete] as [IsObsolete],
[CLH].[IsSystem] as [IsSystem], [CLH].[CheckTypeId] as [CheckTypeId], 
[CLH].[VehicleTypeId] as [VehicleTypeId], [CLH].[Id] as [Id], [CLH].[CreatedDateTime] as [CreatedDateTime], 
[CLH].[UpdatedDateTime] as [UpdatedDateTime], [CT].[Name] as [CheckType__Name], 
[CT].[IsSystem] as [CheckType__IsSystem], [CT].[Id] as [CheckType__Id], 
[CT].[CreatedDateTime] as [CheckType__CreatedDateTime], 
[CT].[UpdatedDateTime] as [CheckType__UpdatedDateTime] FROM [CheckListHeader] [CLH]
LEFT JOIN [CheckType] [CT] ON [CLH].[CheckTypeId] = [CT].[Id]
WHERE ([CLH].[CheckTypeId] = @0)
ORDER BY [VehicleTypeId] ASC
```

# Conclusions

If the project is small with small amount of data, I suggest to use entity framework, but if the project can get a large amount of data It’s very clear [NPOCO](https://github.com/schotime/NPoco/wiki) we should use have the best test performance for more records results, at this moment is very easy to use and it 's possible to have the same functionalities like we have with entity framework, “includes,joins”, exchange data directly with the object using LINQ and for me the most relevant **SQL Transaction Support.**
