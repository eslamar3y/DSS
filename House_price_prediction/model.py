# Import Libraries
import numpy as np
import pandas as pd
import joblib

from sklearn.preprocessing import StandardScaler
from sklearn.model_selection import train_test_split

from sklearn.linear_model import LinearRegression
from sklearn.metrics import mean_squared_error

# load data
df = pd.read_csv("data/ohe_data_reduce_cat_class.csv")

# Split data
# train 80% test 20% of data to check the accuracy of model
X = df.drop('price', axis=1)
y = df['price']
X_train, X_test, y_train, y_test = train_test_split(
    X, y, test_size=0.2, random_state=51)

# feature scaling
# remove not important features
# This scaling process ensures that each feature has the same mean and standard deviation,
# is typically done to improve the performance of machine learning models
sc = StandardScaler()
sc.fit(X_train)
X_train = sc.transform(X_train)
X_test = sc.transform(X_test)


#  Model

lr = LinearRegression()
# lr_lasso = Lasso()
# lr_ridge = Ridge()

# root mean square error
# get square error  between 2 values


def rmse(y_test, y_pred):
    return np.sqrt(mean_squared_error(y_test, y_pred))


# train data
lr.fit(X_train, y_train)
# get accuracy of model "test"
lr_score = lr.score(X_test, y_test)
# y in data and y predicted to get defference   "error"
lr_rmse = rmse(y_test, lr.predict(X_test))
lr_score, lr_rmse


# it help to get predicted value of house  by providing features value
def predict_house_price(bath, balcony, total_sqft_int, bhk, price_per_sqft, area_type, availability, location):

    # create zero numpy array, len = 107 as input value for model
    x = np.zeros(len(X.columns))

    # adding feature's value accorind to their column index
    x[0] = bath
    x[1] = balcony
    x[2] = total_sqft_int
    x[3] = bhk
    x[4] = price_per_sqft

    if "availability" == "Ready To Move":
        x[8] = 1

    if 'area_type'+area_type in X.columns:
        area_type_index = np.where(X.columns == "area_type"+area_type)[0][0]
        x[area_type_index] = 1

    if 'location_'+location in X.columns:
        loc_index = np.where(X.columns == "location_"+location)[0][0]
        x[loc_index] = 1

    # feature scaling
    # give 2d np array for feature scaling and get 1d scaled np array
    x = sc.transform([x])[0]

    # return the predicted value by train liner regression model
    return lr.predict([x])[0]
