appcenter login --token "0469ed8ec3cfad43e95f1981f07ece88d543bc48"

echo "Source Directory"
ls $APPCENTER_SOURCE_DIRECTORY/

echo "Source Directory/packages"
ls $APPCENTER_SOURCE_DIRECTORY/packages

echo "Source Directory/packages/Xamarin UI test 226"
ls $APPCENTER_SOURCE_DIRECTORY/packages/Xamarin.UITest.*

echo "Source Directory/Xamarin UI test 226/tools"
ls $APPCENTER_SOURCE_DIRECTORY/packages/Xamarin.UITest.*/tools

appcenter test run uitest --app "Credit-Card-Team/Credit-Card-App" --devices "Credit-Card-Team/pixels" --app-path $APPCENTER_SOURCE_DIRECTORY/CreditCardValidator.Droid/bin/Release/com.xamarin.example.creditcardvalidator.apk --test-series "master" --locale "en_US" --build-dir $APPCENTER_SOURCE_DIRECTORY/CreditCardValidator.Droid.UITests/bin/Release --uitest-tools-dir $APPCENTER_SOURCE_DIRECTORY/packages/Xamarin.UITest.*/tools 