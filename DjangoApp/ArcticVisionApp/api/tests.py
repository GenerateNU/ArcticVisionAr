from django.test import TestCase

# Create your tests here.
from models import ArcticVisiomUser

a = ArcticVisiomUser(username='a', first_name='a', last_name='a', email='a@a.com', password='a', phone='69420')
a.save()

print(ArcticVisiomUser.objects.all())